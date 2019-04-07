namespace OOSolution
{
    public class Personel
    {
        public string _ad { get; set; }
        public int _cocuksayisi { get; set; }
        public decimal _maas { get; set; }

        public Personel(string ad, int cocuksayisi, decimal maas)
        {
            _ad = ad;
            _cocuksayisi = cocuksayisi;
            _maas = maas;
            Tools.ElemanSayisi++;
        }

        public override string ToString()
        {
            string str = string.Format("işçinin , ismi:{0}, çocuk sayisi:{1}, maaşı:{2},alacağı toplam ücret:{3}", _ad,
                _cocuksayisi, _maas, UcretHesapla());

            return str;
        }

        private int ExtraPara(int k)
        {
            switch (k)
            {
                case 1:
                    return 100;

                case 2:
                    return 250;

                case 0:
                    return 0;

                default:
                    return 400;
            }
        }

        public decimal UcretHesapla()
        {
            decimal ucret = _maas + ExtraPara(_cocuksayisi);

            return ucret;
        }
    }
}