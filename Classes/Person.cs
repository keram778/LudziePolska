﻿using System;

namespace LudziePolska.Classes
{
    public class Person
    {
        public int ID_Osoby { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Pesel { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public string KolorSkory { get; set; }
        public string NazwaWojewodztwa { get; set; }
        public string Zawod { get; set; }
        public int ID_Wojewodztwo { get; set; }
    }
}
