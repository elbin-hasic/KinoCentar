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
