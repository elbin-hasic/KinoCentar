using KinoCentar.Shared.Util;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KinoCentar.API.EntityModels
{
    public class InitData
    {
        public static void Seed(KinoCentarDbContext context)
        {
            context.Database.Migrate();

            if (context.TipKorisnika.Any())
            {
                return; // DB has been seeded
            }

            var tipoviKorisnika = new List<TipKorisnika>();
            tipoviKorisnika.Add(new TipKorisnika { Naziv = "Administrator" });
            tipoviKorisnika.Add(new TipKorisnika { Naziv = "Moderator" });
            tipoviKorisnika.Add(new TipKorisnika { Naziv = "Radnik" });
            tipoviKorisnika.Add(new TipKorisnika { Naziv = "Klijent" });
            context.TipKorisnika.AddRange(tipoviKorisnika);
            // context.SaveChanges();

            var korisnici = new List<Korisnik>();
            var lozinka = "test";
            // #Administrator - Admin
            var lozinkaSalt = UIHelper.GenerateSalt();
            var lozinkaHash = UIHelper.GenerateHash(lozinkaSalt, lozinka);
            korisnici.Add(new Korisnik { KorisnickoIme = "admin", LozinkaSalt = lozinkaSalt, LozinkaHash = lozinkaHash, Ime = "Admin", TipKorisnika = tipoviKorisnika[0] });
            // #Administrator - Desktop
            lozinkaSalt = UIHelper.GenerateSalt();
            lozinkaHash = UIHelper.GenerateHash(lozinkaSalt, lozinka);
            korisnici.Add(new Korisnik { KorisnickoIme = "desktop", LozinkaSalt = lozinkaSalt, LozinkaHash = lozinkaHash, Ime = "Desktop", TipKorisnika = tipoviKorisnika[0] });
            // #Moderator
            lozinkaSalt = UIHelper.GenerateSalt();
            lozinkaHash = UIHelper.GenerateHash(lozinkaSalt, lozinka);
            korisnici.Add(new Korisnik { KorisnickoIme = "moderator", LozinkaSalt = lozinkaSalt, LozinkaHash = lozinkaHash, Ime = "Moderator", TipKorisnika = tipoviKorisnika[1] });
            // #Radnik
            lozinkaSalt = UIHelper.GenerateSalt();
            lozinkaHash = UIHelper.GenerateHash(lozinkaSalt, lozinka);
            korisnici.Add(new Korisnik { KorisnickoIme = "radnik", LozinkaSalt = lozinkaSalt, LozinkaHash = lozinkaHash, Ime = "Radnik", TipKorisnika = tipoviKorisnika[2] });
            // #Mobile
            lozinkaSalt = UIHelper.GenerateSalt();
            lozinkaHash = UIHelper.GenerateHash(lozinkaSalt, lozinka);
            korisnici.Add(new Korisnik { KorisnickoIme = "mobile", LozinkaSalt = lozinkaSalt, LozinkaHash = lozinkaHash, Ime = "Mobile", TipKorisnika = tipoviKorisnika[3] });
            context.Korisnik.AddRange(korisnici);

            var zanrovi = new List<Zanr>();
            zanrovi.Add(new Zanr { Naziv = "Akcija" });
            zanrovi.Add(new Zanr { Naziv = "Avantura" });
            zanrovi.Add(new Zanr { Naziv = "Komedija" });
            zanrovi.Add(new Zanr { Naziv = "Drama" });
            zanrovi.Add(new Zanr { Naziv = "Fantazija" });
            zanrovi.Add(new Zanr { Naziv = "Horor" });
            zanrovi.Add(new Zanr { Naziv = "Misterija" });
            zanrovi.Add(new Zanr { Naziv = "Romantika" });
            zanrovi.Add(new Zanr { Naziv = "Triler" });
            context.Zanr.AddRange(zanrovi);

            var licnosti = new List<FilmskaLicnost>();
            licnosti.Add(new FilmskaLicnost { Ime = "Ryan", Prezime = "Reynolds", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Dwayne", Prezime = "Johnson", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Robert", Prezime = "Downey", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Will", Prezime = "Smith", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Tom", Prezime = "Cruise", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Emily", Prezime = "Blunt", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Jason", Prezime = "Statham", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Brad", Prezime = "Pitt", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Angelina", Prezime = "Jolie", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Gal", Prezime = "Gadot", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Leonardo", Prezime = "DiCaprio", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Margot", Prezime = "Robbie", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Ben", Prezime = "Affleck", IsGlumac = true, IsReziser = true });
            licnosti.Add(new FilmskaLicnost { Ime = "Jennifer", Prezime = "Garner", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Martin", Prezime = "Lawrence", IsGlumac = true, IsReziser = false });
            licnosti.Add(new FilmskaLicnost { Ime = "Jennifer", Prezime = "Aniston", IsGlumac = true, IsReziser = false });
            context.FilmskaLicnost.AddRange(licnosti);

            var sale = new List<Sala>();
            for (int i = 1; i <= 5; i++)
            {
                sale.Add(new Sala { Naziv = $"Sala {i}", BrojSjedista = RandomBroj() });
            }
            context.Sala.AddRange(sale);

            var jedMjere = new List<JedinicaMjere>();
            jedMjere.Add(new JedinicaMjere { KratkiNaziv = "kom", Naziv = "Komad" });
            jedMjere.Add(new JedinicaMjere { KratkiNaziv = "kg", Naziv = "Kilogram" });
            jedMjere.Add(new JedinicaMjere { KratkiNaziv = "l", Naziv = "Litar" });
            context.JedinicaMjere.AddRange(jedMjere);

            var reditelji = licnosti.Where(x => x.IsReziser).ToList();

            var filmovi = new List<Film>();
            filmovi.Add(new Film { Naslov = "Toy Story", Trajanje = 81, GodinaSnimanja = 1995, Reditelj = reditelji[0], Zanr = zanrovi[1], Sadrzaj = "Toy Story je računalno-animirani film iz 1995. godine animacijskoga studija Pixar. Redatelj filma je John Lasseter, a glasove u originalnoj verziji posudili su između ostalih i Tom Hanks i Tim Allen. Producenti su Ralph Guggenheim i Bonie Arnold, a film je distribuirao Walt Disney Pictures. Scenarij potpisuju Joss Whedon, Andrew Stanton, Joel Cohen i Alec Sokolow, dok je glazbu skladao Randy Newman. Priča o igračkama je prvi film koji koristio potpunu računalnu animaciju. Priča se usredotočuje na grupu igračaka koje ožive nakon što njihov vlasnik nije prisutan, fokusirajući se na Woodyja, kauboj igračku, i na Buzza Lightyeara, akcijsku igračku astronauta." });
            filmovi.Add(new Film { Naslov = "Avatar", Trajanje = 162, GodinaSnimanja = 2009, Reditelj = reditelji[1], Zanr = zanrovi[2], Sadrzaj = "Avatar je američki znanstvenofantastični film iz 2009. godine, čiji je scenarist i redatelj James Cameron. U glavnim su ulogama Sam Worthington, Zoe Saldana, Sigourney Weaver, Michelle Rodriguez i Stephen Lang. Epska se priča odvija 2154. godine na Pandori, izmišljenom svijetu u dalekom planetarnom sustavu. Ljudi su pristigli na Pandoru kako bi iskorištavali njene izvore vrijednih minerala, čemu se protive domoroci Na'vi, čije se poimanje svijeta zasniva na suživotu s prirodom. Kako bi se približili domorocima, skupina znanstvenika genetičkim inženjerstvom stvara tzv. \"avatare\", tijela naizgled jednaka Na'vijima, ali daljinski upravljana ljudskim umom. Naziv dolazi iz hinduističke filozofije, gdje riječ \"avatar\" označava \"silazak\" ili inkarnaciju božanskog bića (deva) ili najvišeg bića (Boga) na Zemlju u obliku životinje, čovjeka ili nekog drugog bića." });
            context.Film.AddRange(filmovi);

            var dtn = DateTime.Now;

            var projekcije = new List<Projekcija>();
            projekcije.Add(new Projekcija { Cijena = 3m, Datum = dtn, VrijediOd = dtn.AddDays(-15), VrijediDo = dtn.AddDays(15), Film = filmovi[0], Sala = sale[0] });
            projekcije.Add(new Projekcija { Cijena = 4m, Datum = dtn, VrijediOd = dtn.AddDays(-15), VrijediDo = dtn.AddDays(15), Film = filmovi[1], Sala = sale[1] });
            context.Projekcija.AddRange(projekcije);

            var artikli = new List<Artikal>();
            artikli.Add(new Artikal { Sifra = "000001", Naziv = "Kokice", Cijena = 1m, JedinicaMjere = jedMjere[0] });
            artikli.Add(new Artikal { Sifra = "000002", Naziv = "Naćosi", Cijena = 2.5m, JedinicaMjere = jedMjere[0] });
            artikli.Add(new Artikal { Sifra = "000003", Naziv = "Coca-cola", Cijena = 2m, JedinicaMjere = jedMjere[0] });
            context.Artikal.AddRange(artikli);

            var obavijesti = new List<Obavijest>();
            obavijesti.Add(new Obavijest { Naslov = "Dobro došli", Tekst = "Dobro došli na informacijski sistem za podršku rada kino centra", Datum = dtn, Korisnik = korisnici[0] });
            context.Obavijest.AddRange(obavijesti);

            context.SaveChanges();
        }

        private static Random random = new Random();
        private static int RandomBroj()
        {
            int x = random.Next(5, 30);
            return x * 10;
        }
    }
}
