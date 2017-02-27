using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14253607HW2
{
    
    class Islem
    {
        string aracyonu;
        string firca;
        int neredeSatir;
        int neredeSutun;



        public Islem(string aracyonu = "sağ", string firca = "Yukarı", int neredeSatir = 0, int neredeSutun = 0)
        {
            this.neredeSatir = neredeSatir;                             // Arac bilgileri yönü ve nerede olduğunu tutulan bölüm . ilk değerler.
            this.neredeSutun = neredeSutun;
            this.firca = firca;
            this.aracyonu = aracyonu;
        }

        public void cizdir(string komut)
        {

            string[] parcalanmis = komut.Split('+');                    // komutları parçalamak için kullanıldı 
            int boyut = Convert.ToInt32(parcalanmis[0]);
            int[,] matris = new int[boyut, boyut];                      // matris oluşturma








            for (int h = 1; h < parcalanmis.Length; h++)                //parçalanmış komutların uzunluğu kadar döndürüldü
            {




                if (parcalanmis[h] == "1")                              //Fırçanın aşağı inmesi . eğer fırça yukarda ise aşağı indirir. aşağıda ise devam eder( KOMUT 1 )
                {
                    if (firca == "Yukarı")
                    {
                        firca = "Aşağı";
                        matris[neredeSatir, neredeSutun] = 1;           //bulunduğu ilk durumda 1 gelirse olduğu yeri boyaması için
                    }
                    else if (firca == "Aşağı")
                    {
                        firca = "Aşağı";
                    }
                }




                if (parcalanmis[h] == "2")                             //fırçanın yukarı kalkması . fırça aşağıda ise yukarı kalkıcaktır.( KOMUT 2 )
                {
                    if (firca == "Yukarı")
                    {
                        firca = "Yukarı";
                    }
                    else if (firca == "Aşağı")
                    {
                        firca = "Yukarı";
                    }
                }



                if (parcalanmis[h] == "3")                             // Aracı sağa döndürme  ( KOMUT 3 )
                {
                    if (aracyonu == "sağ")
                    {
                        aracyonu = "aşağı";

                    }
                    else if (aracyonu == "aşağı")
                    {
                        aracyonu = "sol";
                    }
                    else if (aracyonu == "sol")
                    {
                        aracyonu = "yukarı";
                    }
                    else if (aracyonu == "yukarı")
                    {
                        aracyonu = "sağ";
                    }

                }






                if (parcalanmis[h] == "4")                              //Araç sola döndürme ( KOMUT 4 )
                {
                    if (aracyonu == "sağ")
                    {
                        aracyonu = "yukarı";

                    }
                    else if (aracyonu == "yukarı")
                    {
                        aracyonu = "sol";
                    }
                    else if (aracyonu == "sol")
                    {
                        aracyonu = "aşağı";
                    }
                    else if (aracyonu == "aşağı")
                    {
                        aracyonu = "sağ";
                    }

                }




                if (parcalanmis[h].Length > 2)                                      //x kadar ilerle bulunduğu kare hariç ( KOMUT 5 )
                {
                    int x = 0;
                    string[] parcalanmis2 = parcalanmis[h].Split('_');              // parçalanmıştan gelen 5_x değeri ni parçalatıp x ' i burda yakaladık

                    x = int.Parse(parcalanmis2[1]);


                    // Arac yonu sağ ise
                    if (aracyonu == "sağ")
                    {
                        if (firca == "Aşağı")
                        {

                            for (int o = 0; o < x; o++)                             //for döngüsüne sokup geçtiği satırları işaretlettik.Fırça "Aşağı" iken
                            {
                                neredeSutun++;
                                if (neredeSutun >= boyut)
                                    neredeSutun = 0;
                                matris[neredeSatir, neredeSutun] = 1;

                            }
                        }
                        else if (firca == "Yukarı")                                 //Fırça yukarıda iken sadece yürüyor. işaretleme yok.
                        {
                            for (int i = 0; i < x; i++)
                            {
                                neredeSutun++;
                                if (neredeSutun >= boyut)
                                    neredeSutun = 0;
                            }

                        }
                    }


                    // Arac yonu sol ise
                    else if (aracyonu == "sol")
                    {
                        if (firca == "Aşağı")
                        {
                            for (int o = 0; o < x; o++)                             //for döngüsüne sokup geçtiği satırları işaretlettik.Fırça "Aşağı" iken
                            {
                                neredeSutun++;
                                if (neredeSutun <= -1)
                                    neredeSutun = boyut - 1;
                                matris[neredeSatir, neredeSutun] = 1;


                            }

                        }

                        else if (firca == "Yukarı")
                        {
                            for (int i = 0; i < x; i++)
                            {
                                neredeSutun++;
                                if (neredeSutun <= 0)
                                    neredeSutun = boyut - 1;

                            }
                        }
                    }


                    // araç yönü aşağı ise
                    else if (aracyonu == "aşağı")
                    {
                        if (firca == "Aşağı")
                        {
                            for (int o = 0; o < x; o++)                             //for döngüsüne sokup geçtiği satırları işaretlettik.Fırça "Aşağı" iken
                            {
                                {
                                    neredeSatir++;
                                    if (neredeSatir >= boyut)
                                        neredeSatir = 0;
                                    matris[neredeSatir, neredeSutun] = 1;

                                }

                            }
                        }
                        else if (firca == "Yukarı")
                        {
                            for (int z = 0; z < x; z++)
                            {
                                neredeSatir++;
                                if (neredeSatir >= boyut)
                                    neredeSatir = 0;
                            }

                        }
                    }


                    // araç yönü yukarı ise
                    else if (aracyonu == "yukarı")
                    {
                        if (firca == "Aşağı")
                        {

                            for (int u = 0; u < x; u++)                             //for döngüsüne sokup geçtiği satırları işaretlettik.Fırça "Aşağı" iken                            
                            {

                                neredeSatir--;
                                if (neredeSatir <= -1)
                                    neredeSatir = boyut - 1;
                                matris[neredeSatir, neredeSutun] = 1;

                            }


                        }

                        else if (firca == "Yukarı")
                        {
                            for (int i = 0; i < x; i++)
                            {
                                neredeSatir--;
                                if (neredeSatir <= 0)
                                    neredeSatir = boyut - 1;
                            }

                        }

                    }


                }





                if (parcalanmis[h] == "6")                     //Bulunduğu kare hariç 3 kare zıplar ve fırça yukarı gelir
                {
                    if (aracyonu == "sağ")
                    {

                        neredeSutun = neredeSutun + 4;
                        if (neredeSutun >= boyut)
                            neredeSutun -= boyut;
                        firca = "Yukarı";
                    }
                    else if (aracyonu == "sol")
                    {
                        neredeSutun = neredeSutun - 4;
                        if (neredeSutun < 0)
                            neredeSutun += boyut;
                        firca = "Yukarı";
                    }
                    else if (aracyonu == "yukarı")
                    {
                        neredeSatir = neredeSatir - 4;
                        if (neredeSatir < 0)
                            neredeSatir += boyut;
                        firca = "Yukarı";
                    }
                    else if (aracyonu == "aşağı")
                    {
                        neredeSatir = neredeSatir + 4;
                        if (neredeSatir >= boyut)
                            neredeSatir -= boyut;
                        firca = "Yukarı";
                    }

                }



                if (parcalanmis[h] == "7")                     //Aracın 180 derece dönüşü
                { 
                    if (aracyonu == "sağ")
                    {
                        aracyonu = "sol";
                    }
                   else if (aracyonu == "sol")
                    {
                        aracyonu = "sağ";
                    }
                    else if (aracyonu == "aşağı")
                    {
                        aracyonu = "yukarı";
                    }
                     else if (aracyonu == "yukarı")
                    {
                        aracyonu = "aşağı";
                    }

                }
            



                if (parcalanmis[h] == "8")                             //Dizi görüntüleme
                {
                    for (int i = 0; i < boyut; i++)                     // matrisin döngüsü NXN boyutunda elde etmek için 2 for kullanıldı iç içe
                    {

                        for (int k = 0; k < boyut; k++)
                        {
                            if (matris[i, k] == 0)
                            {
                                Console.Write(matris[i, k] + " ");
                            }
                            else
                                Console.Write("* ");                        //1 leri "*"  a bu kısımda çevirdik.
                        }
                        Console.WriteLine();
                    }

                }
                if (parcalanmis[h] == "0")                 //çıkış işlemi break ' e girdikten  sonra gelen komutları okumayacaktır
                {

                    break;
                }

            }







        }

    }
}