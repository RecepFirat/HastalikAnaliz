using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastalikAnaliz.Islemler
{
    public enum Hastalik_Belirti
    {  /*nezle**/
        nezleistahKayib,
        nezlenefeshizli,
        nezleDusukAtes,
        nezleagizKuru,
        nezleGucsuzGoruntu,
        nezleburunTikanik,
        nezlehapsirma,

        /*****/
        /*Griportaknezle*/
        Griportaknezleishal,
        /*******/
        /*Grip*/
        Gripsogukter_vetitreme,
        Gripeklemveuzuvagrima,
        Gripbitkinlik,
        Gripbulanti,
        Gripkusma,

        /***lejenellozOrtakGrip***/
        lejenellozOrtakGripBasagrima,
        lejenellozOrtakGripyorgunluk,
        lejenellozOrtakGripyuksekAtes,
        /*****/
        /***lejenellozOrtak***/
        lejenellozOrtakkaslardaagri,
        lejenellozOrtakhuzursuluk,
        lejenellozOrtakdalginlik,
        lejenellozOrtakbilincBulanik,




        /*Ülser**/
        ÜlsermidedeYanma,
        ÜlserBulanti,
        ÜlserKusmaİleGelenRahatlama,
        Ülseristahsizlik,
        /// <summary>
        /// ÜlserAkcigerKanseri
        /// </summary>
        ÜlserAkcigerKanserikilokaybi,


        yemekYediktenSonraMideAgrisi,


        /**ÜlserortakGastrit****/
        ÜlserortakGastritSikAcikma,
        ÜlserortakGastritmidedeagri,
        ÜlserortakGastritsiskinlikVegaz,
        ÜlserortakGastritHazimsizlik,
        /***Gastrit*******/
        GastritmideBölgesindeAgri,
        /***/



        /**MideKanseri****/
        MideKanseriasidliGegirme,
        MideKanserikanamaveYorgunluk,
        MideKanserikanpıhtı,
        MideKanseribulantiVeyutmaGucluk,
        MideKanseriDiskidakan,

        /**TüberkilozBrusella***************/
        TüberkilozBrusellaatesAtaklari,
        TüberkilozBrusellausumeTitremeterlemeataklari,
        TüberkilozBrusellasiddetliKasAgrileri,
        TüberkilozBrusellaKiloKaybi,
        TüberkilozBrusellaBulantiKusmaIshal,
        TüberkilozBrusellaBasAgrisi,
        TüberkilozBrusellakioKaybi,


        /******BoyunFitihi********/
        BoyunFitihivucuttauyusma,
        BoyunFitihikolbacaktagucsuzluk,
        BoyunFitihibulanıkgörme,
        BoyunFitihiçiftGörme,


        /*****AstımortakKoah*********/
        AstımortakKoahoksuruk,
        AstımortakKoahhiriltilisolunum,
        AstımortakKoahgogustetikaniklikvesikismahissi,
        AstımortakKoahsolukalipverirkenislikhissi, nefesdarligi,


        /*****koah*******/
        koahbalgamcıkarma,

        /*****AkcigerKanseri*****/
        AkcigerKanserigecmeyenOksuruk,
        AkcigerKanseriOKsurukteKan,
        AkcigerKanserigiderekkotulesenGogusagrisi,
        AkcigerKanseriıstahsizlik,
        AkcigerKanserisesKisikligi,
        AkcigerKanserihalsizlik_Yorgunluk,
        AkcigerKanserikemikagrisi,
        AkcigerKanseriSürekliZature,
        AkcigerKanseriSırtVEkalcadaagri,
        /**BelFitigi**/
        belvebacaqkagrisi,
        toparlayarakYurume,

        /**prostatKanseri**/
        prostatKanseriıdraryapmaguclugu,
        prostatKanseriıdrarakısındakuvvetazalması,
        prostatKanseriMenideyadaidrardakangörülmesi,
        prostatKanseriBosalmaesnasındaagrı,
        prostatKanseriKasıkbölgesinderahatsızlıkhissi,
        prostatKanseriKemikagrıları,
        prostatKanseriSertlesmebozukluğu,



        /**PanıkAtak*/
        PanıkAtakGöğüsağrısıyadagöğüstesıkıĢma,
        PanıkAtakÇarpıntıkalbinkuvvetliyadahızlıvurması,
        PanıkAtakTerleme,
        PanıkAtakNefesdarlığıyadaboğulurgibiolma,
        PanıkAtakSoluğunkesilmesi,
        BagdönmesisersemlikdüĢecekyadabayılacakgibiolma,
        UyuĢmayadakarıncalanma,
        ÜĢümeürpermeyadaatesbasması,                               
        Bulantıyadakarınağrısı,
        Titremeyadasarsılma,
        Kendiniyadaçevresindekilerideğismistuhafvefarklıhissetme,
        Kontrolünükaybetmeyadaçıldırmakorkusu,
        Ölümkorkusu,




        /******KalpKrizi*******/
        KalpKrizigogusagri,
        KalpKrizibulantiKusma,
        KalpKrizioksuruk,




        /******Hipertiroid********/
        HipertiroidÇarpıntı,
        HipertiroidKilokaybı,
        HipertiroidKaslardazayıflık,
        HipertiroidSaçlardaincelmevedökülme,
        HipertiroidUykusuzluk,
        HipertiroidNemliciltveciltteincelme,
        HipertiroidAĢırıterleme,
        HipertiroidBağırsakhareketlerindeartısveishal,
        HipertiroidAdetdüzenindebozulma,
        HipertiroidSinirlivetahammülsüzolmadurumu,
        HipertiroidGözlerdeileridoğrufırlama,
        HipertiroidSıcağatahammülsüzlük,
        HipertiroidErkeklerdememebüyümesi,
        Tiroitbezindebüyümeolusması,
        Kemikerimesi,
        Hiperaktivite,
        Libidokaybı,
        Cilttekırmızıyumrular,
        Agırısusama,


        /****sunizit*******/
        sunizitpastanalakıntı,
        sunizityuksekates,
        uzunsurenburunakintisi,





        /////***MĠGREN**/
        ataklibasagrisi,
    }
}
