# Proiect Gestiune Vânzări - C# Windows Forms

Acesta este un proiect, realizat în C# cu .NET Framework 4.8 și Windows Forms. Aplicația oferă o soluție completă pentru gestionarea vânzărilor, incluzând module pentru clienți, produse, tranzacții și utilizatori cu roluri.

## Cuprins
- [Descriere Generală](#descriere-generală)
- [Tehnologii Folosite](#tehnologii-folosite)
- [Funcționalități Implementate](#funcționalități-implementate)
- [Cerințe de Sistem și Configurare](#cerințe-de-sistem-și-configurare)
- [Ghid de Utilizare](#ghid-de-utilizare)
- [Structura Proiectului](#structura-proiectului)
- [Detalii Tehnice de Implementare](#detalii-tehnice-de-implementare)
- [Contribuitori](#contribuitori)

## Descriere Generală

Aplicația "Gestiune Vânzări" este o soluție desktop de tip MDI care permite gestionarea operațiunilor de bază ale unei mici afaceri. Sistemul include funcționalități de CRUD pentru entitățile principale, un sistem de autentificare bazat pe roluri și capabilități de raportare vizuală.

**Module Principale:**
- **Gestiune Clienți:** Adăugarea, modificarea, ștergerea și vizualizarea clienților.
- **Gestiune Produse:** Gestionarea catalogului de produse, inclusiv prețuri și stocuri.
- **Gestiune Tranzacții:** Înregistrarea vânzărilor, adăugarea produselor în coș, actualizarea automată a stocurilor.
- **Gestiune Utilizatori:** Un sistem administrativ pentru crearea și gestionarea conturilor de utilizator cu roluri (Admin, Operator).
- **Rapoarte Vizuale:** Prezentarea grafică a datelor agregate despre vânzări.

## Tehnologii Folosite
- **Limbaj:** C#
- **Framework:** .NET Framework 4.8
- **Interfață Grafică:** Windows Forms
- **Bază de Date:** SQL Server (recomandat Express sau LocalDB)
- **Acces la Date:** ADO.NET (folosind `SqlConnection`, `SqlCommand`, `SqlTransaction` etc.)

## Funcționalități Implementate

Proiectul acoperă o gamă largă de cerințe tehnice, demonstrând concepte cheie din programarea aplicațiilor Windows:

- **Arhitectură pe Niveluri:** O separare clară între interfața utilizator (Formulare), logica de acces la date (Servicii/ManagerDate) și modelul de date (Clase).
- **Persistența Datelor în Bază de Date:** Toate datele sunt stocate și gestionate într-o bază de date SQL Server.
- **Operațiuni CRUD Complete:** Implementare completă pentru toate modulele principale.
- **Sistem de Autentificare și Autorizare:** Utilizatori cu roluri (`Admin`, `Operator`) care au acces diferențiat la funcționalitățile aplicației. Parolele sunt stocate în mod securizat folosind hashing (SHA256).
- **Validarea Datelor:** Validări la nivel de formular (câmpuri obligatorii, formate corecte pentru email/telefon) folosind `ErrorProvider`.
- **Interfață MDI:** Utilizarea unui formular principal ca MDI container pentru o experiență de lucru organizată.
- **Controale Custom:** Crearea și utilizarea unui control de utilizator (`LabeledTextBox`) pentru a standardiza câmpurile de input.
- **Meniuri și Toolbars:** Implementarea unei interfețe intuitive cu meniuri principale, meniuri contextuale și bare de instrumente pentru acces rapid.
- **Acceleratori de la Tastatură:** Suport pentru shortcut-uri (ex: Ctrl+S pentru salvare) pentru o productivitate sporită.
- **Drag & Drop:** Funcționalitate interactivă pentru adăugarea produselor într-o tranzacție.
- **Imprimare Documente:** Generarea și previzualizarea/imprimarea unui document (bon/factură proformă) pentru o tranzacție.
- **Grafice și Rapoarte:** Prezentarea vizuală a datelor agregate folosind controlul `Chart`.
- **Salvare/Restaurare din Fișier:** Funcționalitate de backup și restaurare pentru datele despre clienți și produse, folosind serializare binară.

## Cerințe de Sistem și Configurare

Pentru a rula acest proiect, aveți nevoie de următoarele:

1.  **Visual Studio:** Versiunea 2019 sau 2022, cu workload-ul ".NET desktop development" instalat.
2.  **SQL Server:** O instanță de SQL Server. Se recomandă **SQL Server Express LocalDB**, care este de obicei inclus cu Visual Studio.
3.  **.NET Framework:** Versiunea 4.8 (sau compatibilă).

### Pași pentru Configurare

1.  **Clonați sau descărcați repository-ul:**
    ```bash
    git clone https://github.com/auxeniu/Sales-Management-App.git
    ```

2.  **Configurarea Bazei de Date:**
    *   Deschideți proiectul în Visual Studio.
    *   Găsiți fișierul `GenerareBazaDeDate.sql` în directorul proiectului. Acest script va crea tabelele necesare și va insera date de test.
    *   Conectați-vă la instanța dvs. de SQL Server (LocalDB) folosind **SQL Server Object Explorer** din Visual Studio (View -> SQL Server Object Explorer).
    *   Creați o nouă bază de date numită `VanzariDB`. Click dreapta pe `Databases` -> `New Database`.
    *   Click dreapta pe noua bază de date `VanzariDB` -> `New Query`.
    *   Copiați conținutul fișierului `GenerareBazaDeDate.sql` în fereastra de interogare și executați-l. Acest pas va crea tabelele `Clienti`, `Produse`, `Tranzactii`, `DetaliiTranzactie` și `Utilizatori`.

3.  **Verificarea Connection String:**
    *   Deschideți fișierul `App.config` din proiect.
    *   Verificați dacă `connectionString`-ul corespunde setărilor dvs. Valoarea implicită este configurată pentru SQL Server Express LocalDB:
      ```xml
      <add name="ProiectVanzariConStr" 
           connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=VanzariDB;Integrated Security=True;" 
           providerName="System.Data.SqlClient"/>
      ```

4.  **Compilare și Rulare:**
    *   Asigurați-vă că pachetul `System.Windows.Forms.DataVisualization` este referențiat corect (necesar pentru grafice). Dacă apar erori, adăugați referința manual (Click dreapta pe References -> Add Reference -> Assemblies -> Framework -> bifați `System.Windows.Forms.DataVisualization`).
    *   Compilați proiectul (Build -> Rebuild Solution).
    *   Rulați aplicația (apăsând F5 sau butonul Start).

## Ghid de Utilizare

1.  **Autentificare:**
    *   La prima rulare, aplicația va asigura existența unui cont de administrator.
    *   Folosiți următoarele credențiale pentru a vă autentifica prima dată:
        *   **Nume Utilizator:** `admin`
        *   **Parolă:** `admin1234`

2.  **Navigare:**
    *   Folosiți meniul principal sau bara de instrumente pentru a accesa diferitele module (Clienți, Produse, Tranzacții, etc.).
    *   Aplicația utilizează o interfață MDI, permițând deschiderea mai multor ferestre simultan.

3.  **Gestiune Utilizatori (Doar Admin):**
    *   Din meniul "Gestiune" -> "Utilizatori", administratorul poate crea conturi noi (cu rol de `Admin` sau `Operator`), modifica conturi existente (schimba rolul, parola, starea de activare) sau șterge utilizatori.

4.  **Restaurare din Fișier:**
    *   Pentru a testa funcționalitatea de restaurare, mai întâi salvați datele (clienți sau produse) într-un fișier folosind meniul "Fișier" -> "Date".
    *   După restaurarea unui fișier, datele sunt încărcate în formularul corespunzător. Pentru a le persista în baza de date, folosiți butonul dedicat **"Salvare Date Restaurate în DB"** care va apărea în formular.

## Structura Proiectului
Proiectul este organizat în următoarele directoare pentru o mentenanță ușoară:
- **/Clase:** Conține clasele model care reprezintă entitățile din aplicație (ex: `Client.cs`, `Utilizator.cs`). Include și excepții custom.
- **/ControaleUtilizator:** Conține controale custom create pentru proiect (ex: `LabeledTextBox.cs`).
- **/Formulare:** Conține toate ferestrele aplicației (ex: `FormPrincipal.cs`, `FormLogin.cs`).
- **/Servicii:** Conține clasele care gestionează logica de business și accesul la date (ex: `ManagerDate.cs`, `SesiuneUtilizator.cs`).
- **/Properties:** Resursele proiectului, cum ar fi imagini și iconițe.

## Detalii Tehnice de Implementare
- **ADO.NET:** Toate interacțiunile cu baza de date se fac folosind obiectele standard ADO.NET. Se utilizează comenzi parametrizate pentru a preveni atacurile de tip SQL Injection.
- **Tranzacții SQL:** Operațiunile critice, precum salvarea unei tranzacții de vânzare (care implică inserarea în mai multe tabele și actualizarea stocurilor), sunt încapsulate în tranzacții SQL (`SqlTransaction`) pentru a asigura integritatea datelor (atomicitate).
- **Serializare Binară:** Salvarea și restaurarea datelor în/din fișiere se realizează prin serializare binară folosind `BinaryFormatter`.
- **GDI+:** Imprimarea documentelor este realizată prin desenare directă pe `Graphics` object în evenimentul `PrintPage` al unui `PrintDocument`.
