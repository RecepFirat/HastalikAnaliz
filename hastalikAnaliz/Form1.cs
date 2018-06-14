using hastalikAnaliz.Islemler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastalikAnaliz
{
    public partial class Ana_Main : Form
    {
        public Ana_Main()
        {
            InitializeComponent();
        }

        private void Btn_Anket_Sonuc_Click(object sender, EventArgs e)
        {
            switch (Hastalik_Belirti)
            {
                case Hastalik_Belirti.nezleistahKayib:
                    break;
                case Hastalik_Belirti.nezlenefeshizli:
                    break;
                case Hastalik_Belirti.nezleDusukAtes:
                    break;
                case Hastalik_Belirti.nezleagizKuru:
                    break;
                case Hastalik_Belirti.nezleGucsuzGoruntu:
                    break;
                case Hastalik_Belirti.nezleburunTikanik:
                    break;
                case Hastalik_Belirti.nezlehapsirma:
                    break;
                case Hastalik_Belirti.Griportaknezleishal:
                    break;
                case Hastalik_Belirti.Gripsogukter_vetitreme:
                    break;
                case Hastalik_Belirti.Gripeklemveuzuvagrima:
                    break;
                case Hastalik_Belirti.Gripbitkinlik:
                    break;
                case Hastalik_Belirti.Gripbulanti:
                    break;
                case Hastalik_Belirti.Gripkusma:
                    break;
                case Hastalik_Belirti.lejenellozOrtakGripBasagrima:
                    break;
                case Hastalik_Belirti.lejenellozOrtakGripyorgunluk:
                    break;
                case Hastalik_Belirti.lejenellozOrtakGripyuksekAtes:
                    break;
                case Hastalik_Belirti.lejenellozOrtakkaslardaagri:
                    break;
                case Hastalik_Belirti.lejenellozOrtakhuzursuluk:
                    break;
                case Hastalik_Belirti.lejenellozOrtakdalginlik:
                    break;
                case Hastalik_Belirti.lejenellozOrtakbilincBulanik:
                    break;
                case Hastalik_Belirti.ÜlsermidedeYanma:
                    break;
                case Hastalik_Belirti.ÜlserBulanti:
                    break;
                case Hastalik_Belirti.ÜlserKusmaİleGelenRahatlama:
                    break;
                case Hastalik_Belirti.Ülseristahsizlik:
                    break;
                case Hastalik_Belirti.ÜlserAkcigerKanserikilokaybi:
                    break;
                case Hastalik_Belirti.yemekYediktenSonraMideAgrisi:
                    break;
                case Hastalik_Belirti.ÜlserortakGastritSikAcikma:
                    break;
                case Hastalik_Belirti.ÜlserortakGastritmidedeagri:
                    break;
                case Hastalik_Belirti.ÜlserortakGastritsiskinlikVegaz:
                    break;
                case Hastalik_Belirti.ÜlserortakGastritHazimsizlik:
                    break;
                case Hastalik_Belirti.GastritmideBölgesindeAgri:
                    break;
                case Hastalik_Belirti.MideKanseriasidliGegirme:
                    break;
                case Hastalik_Belirti.MideKanserikanamaveYorgunluk:
                    break;
                case Hastalik_Belirti.MideKanserikanpıhtı:
                    break;
                case Hastalik_Belirti.MideKanseribulantiVeyutmaGucluk:
                    break;
                case Hastalik_Belirti.MideKanseriDiskidakan:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellaatesAtaklari:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellausumeTitremeterlemeataklari:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellasiddetliKasAgrileri:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellaKiloKaybi:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellaBulantiKusmaIshal:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellaBasAgrisi:
                    break;
                case Hastalik_Belirti.TüberkilozBrusellakioKaybi:
                    break;
                case Hastalik_Belirti.BoyunFitihivucuttauyusma:
                    break;
                case Hastalik_Belirti.BoyunFitihikolbacaktagucsuzluk:
                    break;
                case Hastalik_Belirti.BoyunFitihibulanıkgörme:
                    break;
                case Hastalik_Belirti.BoyunFitihiçiftGörme:
                    break;
                case Hastalik_Belirti.AstımortakKoahoksuruk:
                    break;
                case Hastalik_Belirti.AstımortakKoahhiriltilisolunum:
                    break;
                case Hastalik_Belirti.AstımortakKoahgogustetikaniklikvesikismahissi:
                    break;
                case Hastalik_Belirti.AstımortakKoahsolukalipverirkenislikhissi:
                    break;
                case Hastalik_Belirti.nefesdarligi:
                    break;
                case Hastalik_Belirti.koahbalgamcıkarma:
                    break;
                case Hastalik_Belirti.AkcigerKanserigecmeyenOksuruk:
                    break;
                case Hastalik_Belirti.AkcigerKanseriOKsurukteKan:
                    break;
                case Hastalik_Belirti.AkcigerKanserigiderekkotulesenGogusagrisi:
                    break;
                case Hastalik_Belirti.AkcigerKanseriıstahsizlik:
                    break;
                case Hastalik_Belirti.AkcigerKanserisesKisikligi:
                    break;
                case Hastalik_Belirti.AkcigerKanserihalsizlik_Yorgunluk:
                    break;
                case Hastalik_Belirti.AkcigerKanserikemikagrisi:
                    break;
                case Hastalik_Belirti.AkcigerKanseriSürekliZature:
                    break;
                case Hastalik_Belirti.AkcigerKanseriSırtVEkalcadaagri:
                    break;
                case Hastalik_Belirti.belvebacaqkagrisi:
                    break;
                case Hastalik_Belirti.toparlayarakYurume:
                    break;
                case Hastalik_Belirti.prostatKanseriıdraryapmaguclugu:
                    break;
                case Hastalik_Belirti.prostatKanseriıdrarakısındakuvvetazalması:
                    break;
                case Hastalik_Belirti.prostatKanseriMenideyadaidrardakangörülmesi:
                    break;
                case Hastalik_Belirti.prostatKanseriBosalmaesnasındaagrı:
                    break;
                case Hastalik_Belirti.prostatKanseriKasıkbölgesinderahatsızlıkhissi:
                    break;
                case Hastalik_Belirti.prostatKanseriKemikagrıları:
                    break;
                case Hastalik_Belirti.prostatKanseriSertlesmebozukluğu:
                    break;
                case Hastalik_Belirti.PanıkAtakGöğüsağrısıyadagöğüstesıkıĢma:
                    break;
                case Hastalik_Belirti.PanıkAtakÇarpıntıkalbinkuvvetliyadahızlıvurması:
                    break;
                case Hastalik_Belirti.PanıkAtakTerleme:
                    break;
                case Hastalik_Belirti.PanıkAtakNefesdarlığıyadaboğulurgibiolma:
                    break;
                case Hastalik_Belirti.PanıkAtakSoluğunkesilmesi:
                    break;
                case Hastalik_Belirti.BagdönmesisersemlikdüĢecekyadabayılacakgibiolma:
                    break;
                case Hastalik_Belirti.UyuĢmayadakarıncalanma:
                    break;
                case Hastalik_Belirti.ÜĢümeürpermeyadaatesbasması:
                    break;
                case Hastalik_Belirti.Bulantıyadakarınağrısı:
                    break;
                case Hastalik_Belirti.Titremeyadasarsılma:
                    break;
                case Hastalik_Belirti.Kendiniyadaçevresindekilerideğismistuhafvefarklıhissetme:
                    break;
                case Hastalik_Belirti.Kontrolünükaybetmeyadaçıldırmakorkusu:
                    break;
                case Hastalik_Belirti.Ölümkorkusu:
                    break;
                case Hastalik_Belirti.KalpKrizigogusagri:
                    break;
                case Hastalik_Belirti.KalpKrizibulantiKusma:
                    break;
                case Hastalik_Belirti.KalpKrizioksuruk:
                    break;
                case Hastalik_Belirti.HipertiroidÇarpıntı:
                    break;
                case Hastalik_Belirti.HipertiroidKilokaybı:
                    break;
                case Hastalik_Belirti.HipertiroidKaslardazayıflık:
                    break;
                case Hastalik_Belirti.HipertiroidSaçlardaincelmevedökülme:
                    break;
                case Hastalik_Belirti.HipertiroidUykusuzluk:
                    break;
                case Hastalik_Belirti.HipertiroidNemliciltveciltteincelme:
                    break;
                case Hastalik_Belirti.HipertiroidAĢırıterleme:
                    break;
                case Hastalik_Belirti.HipertiroidBağırsakhareketlerindeartısveishal:
                    break;
                case Hastalik_Belirti.HipertiroidAdetdüzenindebozulma:
                    break;
                case Hastalik_Belirti.HipertiroidSinirlivetahammülsüzolmadurumu:
                    break;
                case Hastalik_Belirti.HipertiroidGözlerdeileridoğrufırlama:
                    break;
                case Hastalik_Belirti.HipertiroidSıcağatahammülsüzlük:
                    break;
                case Hastalik_Belirti.HipertiroidErkeklerdememebüyümesi:
                    break;
                case Hastalik_Belirti.Tiroitbezindebüyümeolusması:
                    break;
                case Hastalik_Belirti.Kemikerimesi:
                    break;
                case Hastalik_Belirti.Hiperaktivite:
                    break;
                case Hastalik_Belirti.Libidokaybı:
                    break;
                case Hastalik_Belirti.Cilttekırmızıyumrular:
                    break;
                case Hastalik_Belirti.Agırısusama:
                    break;
                case Hastalik_Belirti.sunizitpastanalakıntı:
                    break;
                case Hastalik_Belirti.sunizityuksekates:
                    break;
                case Hastalik_Belirti.uzunsurenburunakintisi:
                    break;
                case Hastalik_Belirti.ataklibasagrisi:
                    break;
            }
        }
    }
}
