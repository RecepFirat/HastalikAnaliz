using hastalikAnaliz.Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace hastalikAnaliz
{
    public partial class Ana_Main : Form
    {
        public Ana_Main()
        {
            InitializeComponent();
            checkedListBox1.SelectedIndex = -1;
        }
        int nezle = 0;
        int grip = 0;
        int lejenelloz = 0;
        int ulser = 0;
        int gastrit = 0;
        int mideKanseri = 0;
        int TüberkilozBrusella = 0;
        int BoyunFitihi = 0;
        int astim = 0;
        int koah = 0;
        int akcigerKanseri = 0;
        int belfitigi = 0;
        int prostatKanseri = 0;
        int panikatak = 0;
        int kalpkrizi = 0;
        int Hipertiroid = 0;
        int sunizit = 0;
        int migren = 0;
        private void Btn_Anket_Sonuc_Click(object sender, EventArgs e)
        {
           
           
            // checkedListBox1.SelectedItems
            // checkedListBox1.SelectedItems
            foreach (var item in checkedListBox1.SelectedItems)
            {
               
            }
            MessageBox.Show("  nezle ihtimali " + nezle * 5 +
               "  Grip ihtimali" + grip * 5 + " --- " + "  lejenelloz ihtimali :" + lejenelloz * 5 + " ---  " + "  ülser olma ihtimali: " + ulser * 5 + " --- " +

               "  gastrit olma ihtimali " + gastrit * 5 + "---" + "  mideKanseri olma ihtimali" + mideKanseri * 5 + "---" +
               "  TüberkilozBrusella olma ihtimali: " + TüberkilozBrusella * 5 + " --- " +
               "   BoyunFıtığı olma ihitimali: " + BoyunFitihi * 5 + " ---- " +
               "  astim olma ihtimali: "+ astim*5+"---"+
               "  koah olma ihtimali: "+koah*5+"---"+ "  akcigerKanseri ihtimali: " + akcigerKanseri*5+" --- "+
               "  Bel fıtığı ihtimali: " + belfitigi*5+"---"+ "prostatKanseri ihtimali: " + prostatKanseri*5+" --- "+
               "  Panik Atak ihtimali: " + panikatak*5+ "----"+" Kalp krizi:  "+kalpkrizi*5+" --- "+ "  Hipertiroid ihtimali :" + Hipertiroid*5+" --- "+
               " sünizit ihtimali: " + sunizit*5 +"----"+ "   migren ihtimali : " + migren*5
            );

         

            nezle = 0;
            grip = 0;
            lejenelloz = 0;
            ulser = 0;
            gastrit = 0;
            mideKanseri = 0;
            TüberkilozBrusella = 0;
            BoyunFitihi = 0;
            astim = 0;
            koah = 0;
            akcigerKanseri = 0;
            belfitigi = 0;
            prostatKanseri = 0;
            panikatak = 0;
            kalpkrizi = 0;
            Hipertiroid = 0;
            sunizit = 0;
            migren = 0;
          

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

              
                string[] aranan = checkedListBox1.SelectedItem.ToString().Split(')');
           
                int number = Int32.Parse(aranan[0].Trim());

                switch (number)
                {
                    case 1://Hastalik_Belirti.nezleistahKayib:
                        {
                            nezle++;
                            break;
                        }
                    case 2://Hastalik_Belirti.nezlenefeshizli:
                        {
                            nezle++;
                            break;
                        }
                    case 3://Hastalik_Belirti.nezleDusukAtes:
                        {
                            nezle++;
                            break;
                        }
                    case 4://Hastalik_Belirti.nezleagizKuru:
                        {
                            nezle++;
                            break;
                        }
                    case 5://Hastalik_Belirti.nezleGucsuzGoruntu:
                        {
                            nezle++;
                            break;
                        }
                    case 6://Hastalik_Belirti.nezleburunTikanik:
                        {
                            nezle++;
                            break;
                        }
                    case 7://Hastalik_Belirti.nezlehapsirma:
                        {
                            nezle++;
                            break;
                        }
                    case 8://Hastalik_Belirti.Griportaknezleishal:
                        {
                            nezle++;
                            grip++;
                            break;
                        }
                    case 9: //Hastalik_Belirti.Gripsogukter_vetitreme:
                        {
                            grip++;
                            break;
                        }
                    case 10://Hastalik_Belirti.Gripeklemveuzuvagrima:
                        {
                            grip++;

                            break;
                        }
                    case 11://Hastalik_Belirti.Gripbitkinlik:
                        {
                            grip++;
                            break;
                        }
                    case 12://Hastalik_Belirti.Gripbulanti:
                        {
                            grip++;
                            break;
                        }
                    case 13: //Hastalik_Belirti.Gripkusma:
                        {

                            grip++;
                            break;
                        }
                    case 14://Hastalik_Belirti.lejenellozOrtakGripBasagrima:
                        {
                            grip++;
                            lejenelloz++;

                            break;
                        }
                    case 15://Hastalik_Belirti.lejenellozOrtakGripyorgunluk:
                        {
                            grip++;
                            lejenelloz++;
                            break;
                        }
                    case 16://Hastalik_Belirti.lejenellozOrtakGripyuksekAtes:
                        {
                            grip++;
                            lejenelloz++;
                            break;
                        }
                    case 17://Hastalik_Belirti.lejenellozOrtakkaslardaagri:
                        {
                            grip++;
                            lejenelloz++;
                            break;
                        }
                    case 18:// Hastalik_Belirti.lejenellozOrtakhuzursuluk:
                        {
                            grip++;
                            lejenelloz++;

                            break;
                        }
                    case 19://Hastalik_Belirti.lejenellozOrtakdalginlik:
                        {
                            grip++;
                            lejenelloz++;
                            break;
                        }
                    case 20://Hastalik_Belirti.lejenellozOrtakbilincBulanik:
                        {
                            grip++;
                            lejenelloz++;
                            break;

                        }
                    case 21://Hastalik_Belirti.ÜlsermidedeYanma:
                        {
                            ulser++;
                            break;
                        }
                    case 22://Hastalik_Belirti.ÜlserBulanti:
                        {
                            ulser++;
                            break;
                        }
                    case 23://Hastalik_Belirti.ÜlserKusmaİleGelenRahatlama:
                        {
                            ulser++;
                            break;
                        }
                    case 24://Hastalik_Belirti.Ülseristahsizlik:
                        {
                            ulser++;
                            break;
                        }
                    case 25: //Hastalik_Belirti.ÜlserAkcigerKanserikilokaybi:
                        {
                            ulser++;
                            break;
                        }
                    case 26://Hastalik_Belirti.yemekYediktenSonraMideAgrisi:
                        {
                            ulser++;
                            break;
                        }
                    case 27://Hastalik_Belirti.ÜlserortakGastritSikAcikma:
                        {
                            gastrit++;
                            ulser++;
                            break;
                        }
                    case 28://Hastalik_Belirti.ÜlserortakGastritmidedeagri:
                        {
                            gastrit++;
                            ulser++;
                            break;
                        }
                    case 29://Hastalik_Belirti.ÜlserortakGastritsiskinlikVegaz:
                        {
                            gastrit++;
                            ulser++;
                            break;
                        }
                    case 30://Hastalik_Belirti.ÜlserortakGastritHazimsizlik:
                        {
                            gastrit++;
                            ulser++;
                            break;
                        }
                    case 31://Hastalik_Belirti.GastritmideBölgesindeAgri:
                        {
                            gastrit++;

                            break;
                        }
                    case 32://Hastalik_Belirti.MideKanseriasidliGegirme:
                        {
                            mideKanseri++;
                            break;
                        }
                    case 33://Hastalik_Belirti.MideKanserikanamaveYorgunluk:
                        {
                            mideKanseri++;
                            break;
                        }
                    case 34://Hastalik_Belirti.MideKanserikanpıhtı:
                        {
                            mideKanseri++;
                            break;
                        }
                    case 35://Hastalik_Belirti.MideKanseribulantiVeyutmaGucluk:
                        {
                            mideKanseri++;
                            break;
                        }
                    case 36://Hastalik_Belirti.MideKanseriDiskidakan:
                        {
                            mideKanseri++;
                            break;
                        }
                    case 37://Hastalik_Belirti.TüberkilozBrusellaatesAtaklari:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 38://Hastalik_Belirti.TüberkilozBrusellausumeTitremeterlemeataklari:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 39:// Hastalik_Belirti.TüberkilozBrusellasiddetliKasAgrileri:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 40://Hastalik_Belirti.TüberkilozBrusellaKiloKaybi:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 41://Hastalik_Belirti.TüberkilozBrusellaBulantiKusmaIshal:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 42://Hastalik_Belirti.TüberkilozBrusellaBasAgrisi:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 43://Hastalik_Belirti.TüberkilozBrusellakioKaybi:
                        {
                            TüberkilozBrusella++;
                            break;
                        }
                    case 44://Hastalik_Belirti.BoyunFitihivucuttauyusma:
                        {
                            BoyunFitihi++;
                            break;
                        }
                    case 45://Hastalik_Belirti.BoyunFitihikolbacaktagucsuzluk:
                        {
                            BoyunFitihi++;
                            break;
                        }
                    case 46://Hastalik_Belirti.BoyunFitihibulanıkgörme:
                        {
                            BoyunFitihi++;
                            break;
                        }
                    case 47://Hastalik_Belirti.BoyunFitihiçiftGörme:
                        {
                            BoyunFitihi++;
                            break;
                        }
                    case 48://Hastalik_Belirti.AstımortakKoahoksuruk:
                        {
                            astim++;
                            koah++;
                            break;
                        }
                    case 49:// Hastalik_Belirti.AstımortakKoahhiriltilisolunum:
                        {
                            astim++;
                            koah++;
                            break;
                        }
                    case 50://Hastalik_Belirti.AstımortakKoahgogustetikaniklikvesikismahissi:
                        {
                            astim++;
                            koah++;
                            break;
                        }
                    case 51://Hastalik_Belirti.AstımortakKoahsolukalipverirkenislikhissi:
                        {
                            astim++;
                            koah++;
                            break;
                        }
                    case 52://Hastalik_Belirti.AstımortakKoahnefesdarligi:
                        {
                            astim++;

                            break;
                        }
                    case 53://Hastalik_Belirti.koahbalgamcıkarma:
                        {

                            koah++;
                            break;
                        }
                    case 54://Hastalik_Belirti.AkcigerKanserigecmeyenOksuruk:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 55://Hastalik_Belirti.AkcigerKanseriOKsurukteKan:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 56://Hastalik_Belirti.AkcigerKanserigiderekkotulesenGogusagrisi:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 57://Hastalik_Belirti.AkcigerKanseriıstahsizlik:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 58://Hastalik_Belirti.AkcigerKanserisesKisikligi:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 59://Hastalik_Belirti.AkcigerKanserihalsizlik_Yorgunluk:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 60://Hastalik_Belirti.AkcigerKanserikemikagrisi:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 61://Hastalik_Belirti.AkcigerKanseriSürekliZature:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 62: //Hastalik_Belirti.AkcigerKanseriSırtVEkalcadaagri:
                        {
                            akcigerKanseri++;
                            break;
                        }
                    case 63://Hastalik_Belirti.belvebacaqkagrisi:
                        {
                            belfitigi++;
                            break;
                        }
                    case 64://Hastalik_Belirti.toparlayarakYurume:
                        {
                            belfitigi++;
                            break;
                        }
                    case 65://Hastalik_Belirti.prostatKanseriıdraryapmaguclugu:
                        {
                            prostatKanseri++;

                            break;
                        }
                    case 66://Hastalik_Belirti.prostatKanseriıdrarakısındakuvvetazalması:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 67://Hastalik_Belirti.prostatKanseriMenideyadaidrardakangörülmesi:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 68://Hastalik_Belirti.prostatKanseriBosalmaesnasındaagrı:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 69://Hastalik_Belirti.prostatKanseriKasıkbölgesinderahatsızlıkhissi:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 70:// Hastalik_Belirti.prostatKanseriKemikagrıları:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 71://Hastalik_Belirti.prostatKanseriSertlesmebozukluğu:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 72://Hastalik_Belirti.PanıkAtakGöğüsağrısıyadagöğüstesıkıĢma:
                        {
                            prostatKanseri++;
                            break;
                        }
                    case 73://Hastalik_Belirti.PanıkAtakÇarpıntıkalbinkuvvetliyadahızlıvurması:
                        {
                            panikatak++;
                            break;
                        }
                    case 74://Hastalik_Belirti.PanıkAtakTerleme:
                        {
                            panikatak++;
                            break;
                        }
                    case 75://Hastalik_Belirti.PanıkAtakNefesdarlığıyadaboğulurgibiolma:
                        {
                            panikatak++;
                            break;
                        }
                    case 76:// Hastalik_Belirti.PanıkAtakSoluğunkesilmesi:
                        {
                            panikatak++;
                            break;
                        }
                    case 77://Hastalik_Belirti.BagdönmesisersemlikdüĢecekyadabayılacakgibiolma:
                        {
                            panikatak++;
                            break;
                        }
                    case 78://Hastalik_Belirti.UyuĢmayadakarıncalanma:
                        {
                            panikatak++;
                            break;
                        }
                    case 79:// Hastalik_Belirti.ÜĢümeürpermeyadaatesbasması:
                        {
                            panikatak++;
                            break;
                        }
                    case 80://Hastalik_Belirti.Bulantıyadakarınağrısı:
                        {
                            panikatak++;
                            break;
                        }
                    case 81://Hastalik_Belirti.Titremeyadasarsılma:
                        {
                            panikatak++;
                            break;
                        }
                    case 82://Hastalik_Belirti.Kendiniyadaçevresindekilerideğismistuhafvefarklıhissetme:
                        {
                            panikatak++;
                            break;
                        }
                    case 83:// Hastalik_Belirti.Kontrolünükaybetmeyadaçıldırmakorkusu:
                        {
                            panikatak++;
                            break;
                        }
                    case 84://Hastalik_Belirti.Ölümkorkusu:
                        {
                            panikatak++;
                            break;
                        }
                    case 85://Hastalik_Belirti.KalpKrizigogusagri:
                        {
                            kalpkrizi++;
                            break;
                        }
                    case 86://Hastalik_Belirti.KalpKrizibulantiKusma:
                        {
                            kalpkrizi++;
                            break;
                        }
                    case 87://Hastalik_Belirti.KalpKrizioksuruk:
                        {
                            kalpkrizi++;
                            break;
                        }
                    case 88://Hastalik_Belirti.HipertiroidÇarpıntı:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 89://Hastalik_Belirti.HipertiroidKilokaybı:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 90://Hastalik_Belirti.HipertiroidKaslardazayıflık:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 91://Hastalik_Belirti.HipertiroidSaçlardaincelmevedökülme:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 92://Hastalik_Belirti.HipertiroidUykusuzluk:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 93://Hastalik_Belirti.HipertiroidNemliciltveciltteincelme:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 94://Hastalik_Belirti.HipertiroidAĢırıterleme:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 95://Hastalik_Belirti.HipertiroidBağırsakhareketlerindeartısveishal:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 96://Hastalik_Belirti.HipertiroidAdetdüzenindebozulma:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 97://Hastalik_Belirti.HipertiroidSinirlivetahammülsüzolmadurumu:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 98://Hastalik_Belirti.HipertiroidGözlerdeileridoğrufırlama:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 99://Hastalik_Belirti.HipertiroidSıcağatahammülsüzlük:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 100://Hastalik_Belirti.HipertiroidErkeklerdememebüyümesi:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 101://Hastalik_Belirti.Tiroitbezindebüyümeolusması:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 102://Hastalik_Belirti.Kemikerimesi:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 103://Hastalik_Belirti.Hiperaktivite:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 104://Hastalik_Belirti.Libidokaybı:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 105://Hastalik_Belirti.Cilttekırmızıyumrular:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 106://Hastalik_Belirti.Agırısusama:
                        {
                            Hipertiroid++;
                            break;
                        }
                    case 107://Hastalik_Belirti.sunizitpastanalakıntı:
                        {
                            sunizit++;

                            break;
                        }
                    case 108://Hastalik_Belirti.sunizityuksekates:
                        {
                            sunizit++;
                            break;
                        }
                    case 109://Hastalik_Belirti.uzunsurenburunakintisi:
                        {
                            sunizit++; break;
                        }
                    case 110://Hastalik_Belirti.ataklibasagrisi:
                        {
                            migren++; break;
                        }

                    default:
                        { break; }
                }

          

        }
    }
}


