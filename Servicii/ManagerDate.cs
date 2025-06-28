using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary; 
using ProiectVanzari.Clase; 
using System.Security.Cryptography; 
using System.Text; 

namespace ProiectVanzari.Servicii
{
    public class ManagerDate
    {
        private string _connectionString;

        public ManagerDate()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["ProiectVanzariConStr"].ConnectionString;
            if (string.IsNullOrEmpty(_connectionString))
            {
                
                
                throw new ConfigurationErrorsException("Connection string 'ProiectVanzariConStr' nu a fost găsit în App.config.");
            }
        }

        
        public static string ComputeSha256Hash(string rawData)
        {
            if (string.IsNullOrEmpty(rawData)) 
                return string.Empty; 

            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        

        public bool EmailClientExista(string email, int idClientExclus = 0) 
        {
            if (string.IsNullOrWhiteSpace(email)) return false; 

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                
                string query = "SELECT COUNT(*) FROM Clienti WHERE Email = @Email" + (idClientExclus > 0 ? " AND IdClient <> @IdClientExclus" : "");
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);
                    if (idClientExclus > 0)
                    {
                        cmd.Parameters.AddWithValue("@IdClientExclus", idClientExclus);
                    }
                    return (int)cmd.ExecuteScalar() > 0;
                }
            }
        }
        public Utilizator VerificaUtilizator(string numeUtilizator, string parolaInClar)
        {
            Utilizator utilizator = null;
            string parolaHash = ComputeSha256Hash(parolaInClar);

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT IdUtilizator, NumeUtilizator, ParolaHash, Rol, EsteActiv FROM Utilizatori WHERE NumeUtilizator = @NumeUtilizator AND ParolaHash = @ParolaHash AND EsteActiv = 1";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeUtilizator", numeUtilizator);
                    cmd.Parameters.AddWithValue("@ParolaHash", parolaHash);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            utilizator = new Utilizator
                            {
                                IdUtilizator = reader.GetInt32(0),
                                NumeUtilizator = reader.GetString(1),
                                ParolaHash = reader.GetString(2),
                                Rol = reader.GetString(3),
                                EsteActiv = reader.GetBoolean(4)
                            };
                        }
                    }
                }
            }
            return utilizator;
        }

        public Utilizator GetUtilizatorByNume(string numeUtilizator)
        {
            Utilizator utilizator = null;
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT IdUtilizator, NumeUtilizator, ParolaHash, Rol, EsteActiv FROM Utilizatori WHERE NumeUtilizator = @NumeUtilizator";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeUtilizator", numeUtilizator);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            utilizator = new Utilizator
                            {
                                IdUtilizator = reader.GetInt32(0),
                                NumeUtilizator = reader.GetString(1),
                                ParolaHash = reader.GetString(2),
                                Rol = reader.GetString(3),
                                EsteActiv = reader.GetBoolean(4)
                            };
                        }
                    }
                }
            }
            return utilizator;
        }

        public List<Utilizator> IncarcaTotiUtilizatorii()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT IdUtilizator, NumeUtilizator, Rol, EsteActiv FROM Utilizatori ORDER BY NumeUtilizator";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            utilizatori.Add(new Utilizator
                            {
                                IdUtilizator = reader.GetInt32(0),
                                NumeUtilizator = reader.GetString(1),
                                Rol = reader.GetString(2),
                                EsteActiv = reader.GetBoolean(3)
                            });
                        }
                    }
                }
            }
            return utilizatori;
        }

        public int AdaugaUtilizator(Utilizator utilizator, string parolaInClar)
        {
            if (GetUtilizatorByNume(utilizator.NumeUtilizator) != null)
            {
                throw new InvalidOperationException("Un utilizator cu acest nume există deja.");
            }
            if (string.IsNullOrWhiteSpace(parolaInClar))
            {
                throw new ArgumentException("Parola nu poate fi goală la adăugarea unui utilizator nou.", nameof(parolaInClar));
            }

            string parolaHash = ComputeSha256Hash(parolaInClar);
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Utilizatori (NumeUtilizator, ParolaHash, Rol, EsteActiv) OUTPUT INSERTED.IdUtilizator VALUES (@NumeUtilizator, @ParolaHash, @Rol, @EsteActiv)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                    cmd.Parameters.AddWithValue("@ParolaHash", parolaHash);
                    cmd.Parameters.AddWithValue("@Rol", utilizator.Rol);
                    cmd.Parameters.AddWithValue("@EsteActiv", utilizator.EsteActiv);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void ActualizeazaUtilizator(Utilizator utilizator, string parolaNouaInClar = null)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string checkNameQuery = "SELECT COUNT(*) FROM Utilizatori WHERE NumeUtilizator = @NumeUtilizator AND IdUtilizator <> @IdUtilizator";
                using (SqlCommand checkCmd = new SqlCommand(checkNameQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                    checkCmd.Parameters.AddWithValue("@IdUtilizator", utilizator.IdUtilizator);
                    if ((int)checkCmd.ExecuteScalar() > 0)
                    {
                        throw new InvalidOperationException("Numele de utilizator specificat este deja folosit de un alt cont.");
                    }
                }

                string query;
                if (!string.IsNullOrEmpty(parolaNouaInClar))
                {
                    string parolaNouaHash = ComputeSha256Hash(parolaNouaInClar);
                    query = "UPDATE Utilizatori SET NumeUtilizator = @NumeUtilizator, ParolaHash = @ParolaHash, Rol = @Rol, EsteActiv = @EsteActiv WHERE IdUtilizator = @IdUtilizator";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                        cmd.Parameters.AddWithValue("@ParolaHash", parolaNouaHash);
                        cmd.Parameters.AddWithValue("@Rol", utilizator.Rol);
                        cmd.Parameters.AddWithValue("@EsteActiv", utilizator.EsteActiv);
                        cmd.Parameters.AddWithValue("@IdUtilizator", utilizator.IdUtilizator);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    query = "UPDATE Utilizatori SET NumeUtilizator = @NumeUtilizator, Rol = @Rol, EsteActiv = @EsteActiv WHERE IdUtilizator = @IdUtilizator";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                        cmd.Parameters.AddWithValue("@Rol", utilizator.Rol);
                        cmd.Parameters.AddWithValue("@EsteActiv", utilizator.EsteActiv);
                        cmd.Parameters.AddWithValue("@IdUtilizator", utilizator.IdUtilizator);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        public void StergeUtilizator(int idUtilizator)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string queryGetRol = "SELECT Rol FROM Utilizatori WHERE IdUtilizator = @IdUtilizator";
                string rolUtilizatorDeSters = null;
                using (SqlCommand cmdGet = new SqlCommand(queryGetRol, conn))
                {
                    cmdGet.Parameters.AddWithValue("@IdUtilizator", idUtilizator);
                    rolUtilizatorDeSters = cmdGet.ExecuteScalar()?.ToString();
                }

                if (rolUtilizatorDeSters == RolUtilizator.Admin)
                {
                    string queryCountAdmins = "SELECT COUNT(*) FROM Utilizatori WHERE Rol = @RolAdmin AND EsteActiv = 1 AND IdUtilizator <> @IdUtilizatorExclus";
                    using (SqlCommand cmdCount = new SqlCommand(queryCountAdmins, conn))
                    {
                        cmdCount.Parameters.AddWithValue("@RolAdmin", RolUtilizator.Admin);
                        cmdCount.Parameters.AddWithValue("@IdUtilizatorExclus", idUtilizator); 
                        
                        
                        
                    }
                    
                    string queryTotalAdminsActivi = "SELECT COUNT(*) FROM Utilizatori WHERE Rol = @RolAdmin AND EsteActiv = 1";
                    using (SqlCommand cmdTotalAdmins = new SqlCommand(queryTotalAdminsActivi, conn))
                    {
                        cmdTotalAdmins.Parameters.AddWithValue("@RolAdmin", RolUtilizator.Admin);
                        int totalAdminsActivi = (int)cmdTotalAdmins.ExecuteScalar();
                        
                        if (totalAdminsActivi == 1)
                        {
                            
                            string queryEsteAcestAdmin = "SELECT EsteActiv FROM Utilizatori WHERE IdUtilizator = @IdUtilizator";
                            using (SqlCommand cmdCheckUnic = new SqlCommand(queryEsteAcestAdmin, conn))
                            {
                                cmdCheckUnic.Parameters.AddWithValue("@IdUtilizator", idUtilizator);
                                bool esteActiv = (bool)cmdCheckUnic.ExecuteScalar();
                                if (esteActiv)
                                {
                                    throw new InvalidOperationException("Nu puteți șterge unicul administrator activ al sistemului.");
                                }
                            }
                        }
                    }
                }

                string queryDelete = "DELETE FROM Utilizatori WHERE IdUtilizator = @IdUtilizator";
                using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                {
                    cmd.Parameters.AddWithValue("@IdUtilizator", idUtilizator);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AsiguraExistentaAdminDefault()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Utilizatori WHERE Rol = @RolAdmin";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RolAdmin", RolUtilizator.Admin); 
                    int adminCount = (int)cmd.ExecuteScalar();
                    if (adminCount == 0)
                    {
                        Utilizator adminDefault = new Utilizator
                        {
                            NumeUtilizator = "admin", 
                            Rol = RolUtilizator.Admin,
                            EsteActiv = true
                        };
                        AdaugaUtilizator(adminDefault, "admin"); 
                        Console.WriteLine("Utilizator Admin default creat cu parola 'admin'. Schimbați parola!");
                    }
                }
            }
        }

        
        public List<Client> IncarcaClientiDinDb()
        {
            List<Client> clienti = new List<Client>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT IdClient, Nume, Prenume, Adresa, Telefon, Email FROM Clienti ORDER BY Nume, Prenume";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            clienti.Add(new Client
                            {
                                IdClient = reader.GetInt32(0),
                                Nume = reader.GetString(1),
                                Prenume = reader.IsDBNull(2) ? null : reader.GetString(2),
                                Adresa = reader.IsDBNull(3) ? null : reader.GetString(3),
                                Telefon = reader.IsDBNull(4) ? null : reader.GetString(4),
                                Email = reader.IsDBNull(5) ? null : reader.GetString(5)
                            });
                        }
                    }
                }
            }
            return clienti;
        }

        public int AdaugaClientInDb(Client client)
        {
            if (EmailClientExista(client.Email)) 
            {
                throw new InvalidOperationException($"Email-ul '{client.Email}' este deja folosit de un alt client.");
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Clienti (Nume, Prenume, Adresa, Telefon, Email) OUTPUT INSERTED.IdClient VALUES (@Nume, @Prenume, @Adresa, @Telefon, @Email)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nume", client.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", (object)client.Prenume ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresa", (object)client.Adresa ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefon", (object)client.Telefon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)client.Email ?? DBNull.Value);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void ActualizeazaClientInDb(Client client)
        {
            if (EmailClientExista(client.Email, client.IdClient)) 
            {
                throw new InvalidOperationException($"Email-ul '{client.Email}' este deja folosit de un alt client.");
            }
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Clienti SET Nume = @Nume, Prenume = @Prenume, Adresa = @Adresa, Telefon = @Telefon, Email = @Email WHERE IdClient = @IdClient";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nume", client.Nume);
                    cmd.Parameters.AddWithValue("@Prenume", (object)client.Prenume ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Adresa", (object)client.Adresa ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Telefon", (object)client.Telefon ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)client.Email ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@IdClient", client.IdClient);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void StergeClientDinDb(int idClient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string updateTranzactiiQuery = "UPDATE Tranzactii SET IdClient = NULL WHERE IdClient = @IdClient";
                using (SqlCommand cmdUpdate = new SqlCommand(updateTranzactiiQuery, conn))
                {
                    cmdUpdate.Parameters.AddWithValue("@IdClient", idClient);
                    cmdUpdate.ExecuteNonQuery();
                }

                string query = "DELETE FROM Clienti WHERE IdClient = @IdClient";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdClient", idClient);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public List<Produs> IncarcaProduseDinDb()
        {
            List<Produs> produse = new List<Produs>();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT IdProdus, Denumire, Pret, Stoc FROM Produse ORDER BY Denumire";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            produse.Add(new Produs
                            {
                                IdProdus = reader.GetInt32(0),
                                Denumire = reader.GetString(1),
                                Pret = reader.GetDecimal(2),
                                Stoc = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return produse;
        }

        public int AdaugaProdusInDb(Produs produs)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Produse (Denumire, Pret, Stoc) OUTPUT INSERTED.IdProdus VALUES (@Denumire, @Pret, @Stoc)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Denumire", produs.Denumire);
                    cmd.Parameters.AddWithValue("@Pret", produs.Pret);
                    cmd.Parameters.AddWithValue("@Stoc", produs.Stoc);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public void ActualizeazaProdusInDb(Produs produs)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string query = "UPDATE Produse SET Denumire = @Denumire, Pret = @Pret, Stoc = @Stoc WHERE IdProdus = @IdProdus";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Denumire", produs.Denumire);
                    cmd.Parameters.AddWithValue("@Pret", produs.Pret);
                    cmd.Parameters.AddWithValue("@Stoc", produs.Stoc);
                    cmd.Parameters.AddWithValue("@IdProdus", produs.IdProdus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void StergeProdusDinDb(int idProdus)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string checkQuery = "SELECT COUNT(*) FROM DetaliiTranzactie WHERE IdProdus = @IdProdus";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@IdProdus", idProdus);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        throw new InvalidOperationException("Produsul nu poate fi șters deoarece este inclus în tranzacții existente. Îl puteți marca ca inactiv sau actualiza stocul la 0.");
                    }
                }

                string query = "DELETE FROM Produse WHERE IdProdus = @IdProdus";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IdProdus", idProdus);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        
        public List<Tranzactie> IncarcaTranzactiiDinDb()
        {
            var tranzactii = new List<Tranzactie>();
            var clienti = IncarcaClientiDinDb().ToDictionary(c => c.IdClient);
            var produse = IncarcaProduseDinDb().ToDictionary(p => p.IdProdus);

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                string queryTranzactii = "SELECT IdTranzactie, IdClient, DataTranzactie, TotalGeneral FROM Tranzactii ORDER BY DataTranzactie DESC";
                using (SqlCommand cmdTranzactii = new SqlCommand(queryTranzactii, conn))
                {
                    using (SqlDataReader readerTranzactii = cmdTranzactii.ExecuteReader())
                    {
                        while (readerTranzactii.Read())
                        {
                            int idTranzactie = readerTranzactii.GetInt32(0);
                            Client clientAsociat = null;
                            if (!readerTranzactii.IsDBNull(1))
                            {
                                int idClient = readerTranzactii.GetInt32(1);
                                clienti.TryGetValue(idClient, out clientAsociat);
                            }

                            var tranzactie = new Tranzactie
                            {
                                IdTranzactie = idTranzactie,
                                ClientAsociat = clientAsociat,
                                DataTranzactie = readerTranzactii.GetDateTime(2)
                            };
                            tranzactii.Add(tranzactie);
                        }
                    }
                }

                foreach (var tranzactie in tranzactii)
                {
                    string queryDetalii = "SELECT IdProdus, Cantitate, PretUnitarLaVanzare FROM DetaliiTranzactie WHERE IdTranzactie = @IdTranzactie";
                    using (SqlCommand cmdDetalii = new SqlCommand(queryDetalii, conn)) 
                    {
                        cmdDetalii.Parameters.AddWithValue("@IdTranzactie", tranzactie.IdTranzactie);
                        using (SqlDataReader readerDetalii = cmdDetalii.ExecuteReader())
                        {
                            while (readerDetalii.Read())
                            {
                                int idProdus = readerDetalii.GetInt32(0);
                                Produs produsAsociat = null;
                                if (produse.TryGetValue(idProdus, out produsAsociat))
                                {
                                    tranzactie.ProduseVandute.Add(new ProdusVandut
                                    {
                                        ProdusAsociat = new Produs
                                        { 
                                            IdProdus = produsAsociat.IdProdus,
                                            Denumire = produsAsociat.Denumire,
                                            Pret = produsAsociat.Pret, 
                                            Stoc = produsAsociat.Stoc  
                                        },
                                        Cantitate = readerDetalii.GetInt32(1),
                                        PretUnitarLaVanzare = readerDetalii.GetDecimal(2)
                                    });
                                }
                            }
                        }
                    }
                }
            }
            return tranzactii;
        }

        public int AdaugaTranzactieInDb(Tranzactie tranzactie)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction sqlTrans = conn.BeginTransaction())
                {
                    try
                    {
                        string queryTranzactie = "INSERT INTO Tranzactii (IdClient, DataTranzactie, TotalGeneral) OUTPUT INSERTED.IdTranzactie VALUES (@IdClient, @DataTranzactie, @TotalGeneral)";
                        int idTranzactie;
                        using (SqlCommand cmdTranzactie = new SqlCommand(queryTranzactie, conn, sqlTrans))
                        {
                            cmdTranzactie.Parameters.AddWithValue("@IdClient", (object)tranzactie.ClientAsociat?.IdClient ?? DBNull.Value);
                            cmdTranzactie.Parameters.AddWithValue("@DataTranzactie", tranzactie.DataTranzactie);
                            cmdTranzactie.Parameters.AddWithValue("@TotalGeneral", tranzactie.TotalGeneral);
                            idTranzactie = (int)cmdTranzactie.ExecuteScalar();
                        }

                        tranzactie.IdTranzactie = idTranzactie;

                        foreach (var pv in tranzactie.ProduseVandute)
                        {
                            string queryDetalii = "INSERT INTO DetaliiTranzactie (IdTranzactie, IdProdus, Cantitate, PretUnitarLaVanzare) VALUES (@IdTranzactie, @IdProdus, @Cantitate, @PretUnitar)";
                            using (SqlCommand cmdDetalii = new SqlCommand(queryDetalii, conn, sqlTrans))
                            {
                                cmdDetalii.Parameters.AddWithValue("@IdTranzactie", idTranzactie);
                                cmdDetalii.Parameters.AddWithValue("@IdProdus", pv.ProdusAsociat.IdProdus);
                                cmdDetalii.Parameters.AddWithValue("@Cantitate", pv.Cantitate);
                                cmdDetalii.Parameters.AddWithValue("@PretUnitar", pv.PretUnitarLaVanzare);
                                cmdDetalii.ExecuteNonQuery();
                            }

                            string queryUpdateStoc = "UPDATE Produse SET Stoc = Stoc - @CantitateVanduta WHERE IdProdus = @IdProdus";
                            using (SqlCommand cmdUpdateStoc = new SqlCommand(queryUpdateStoc, conn, sqlTrans))
                            {
                                cmdUpdateStoc.Parameters.AddWithValue("@CantitateVanduta", pv.Cantitate);
                                cmdUpdateStoc.Parameters.AddWithValue("@IdProdus", pv.ProdusAsociat.IdProdus);
                                cmdUpdateStoc.ExecuteNonQuery();
                            }
                        }
                        sqlTrans.Commit();
                        return idTranzactie;
                    }
                    catch (Exception)
                    {
                        sqlTrans.Rollback();
                        throw;
                    }
                }
            }
        }

        public void StergeTranzactieDinDb(int idTranzactie)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                using (SqlTransaction sqlTrans = conn.BeginTransaction())
                {
                    try
                    {
                        List<ProdusVandut> produseDeRestituit = new List<ProdusVandut>();
                        string queryGetDetalii = "SELECT IdProdus, Cantitate FROM DetaliiTranzactie WHERE IdTranzactie = @IdTranzactie";
                        using (SqlCommand cmdGetDetalii = new SqlCommand(queryGetDetalii, conn, sqlTrans))
                        {
                            cmdGetDetalii.Parameters.AddWithValue("@IdTranzactie", idTranzactie);
                            using (SqlDataReader reader = cmdGetDetalii.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    produseDeRestituit.Add(new ProdusVandut
                                    {
                                        ProdusAsociat = new Produs { IdProdus = reader.GetInt32(0) },
                                        Cantitate = reader.GetInt32(1)
                                    });
                                }
                            }
                        }

                        foreach (var pv in produseDeRestituit)
                        {
                            string queryUpdateStoc = "UPDATE Produse SET Stoc = Stoc + @CantitateRestituita WHERE IdProdus = @IdProdus";
                            using (SqlCommand cmdUpdateStoc = new SqlCommand(queryUpdateStoc, conn, sqlTrans))
                            {
                                cmdUpdateStoc.Parameters.AddWithValue("@CantitateRestituita", pv.Cantitate);
                                cmdUpdateStoc.Parameters.AddWithValue("@IdProdus", pv.ProdusAsociat.IdProdus);
                                cmdUpdateStoc.ExecuteNonQuery();
                            }
                        }

                        
                        string queryDeleteTranzactie = "DELETE FROM Tranzactii WHERE IdTranzactie = @IdTranzactie";
                        using (SqlCommand cmdDeleteTranzactie = new SqlCommand(queryDeleteTranzactie, conn, sqlTrans))
                        {
                            cmdDeleteTranzactie.Parameters.AddWithValue("@IdTranzactie", idTranzactie);
                            cmdDeleteTranzactie.ExecuteNonQuery();
                        }

                        sqlTrans.Commit();
                    }
                    catch (Exception)
                    {
                        sqlTrans.Rollback();
                        throw;
                    }
                }
            }
        }

        
        public void SalveazaClientiInFisier(List<Client> clienti, string caleFisier)
        {
            try
            {
                using (FileStream fs = new FileStream(caleFisier, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, clienti);
                }
            }
            catch (Exception ex)
            {
                
                throw new IOException($"Eroare la salvarea clienților în fișier: {ex.Message}", ex);
            }
        }

        public List<Client> RestaureazaClientiDinFisier(string caleFisier)
        {
            if (!File.Exists(caleFisier)) return new List<Client>();

            try
            {
                using (FileStream fs = new FileStream(caleFisier, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Client>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Eroare la restaurarea clienților din fișier: {ex.Message}", ex);
            }
        }

        public void SalveazaProduseInFisier(List<Produs> produse, string caleFisier)
        {
            try
            {
                using (FileStream fs = new FileStream(caleFisier, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, produse);
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Eroare la salvarea produselor în fișier: {ex.Message}", ex);
            }
        }

        public List<Produs> RestaureazaProduseDinFisier(string caleFisier)
        {
            if (!File.Exists(caleFisier)) return new List<Produs>();
            try
            {
                using (FileStream fs = new FileStream(caleFisier, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (List<Produs>)formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                throw new IOException($"Eroare la restaurarea produselor din fișier: {ex.Message}", ex);
            }
        }
    }
}