using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_RPG;

public class Program
{
    static void Main(string[] args)
    {
        Pemain Karakter = new Pemain();
        Karakter.nama_karakter = "Edwin";
        Karakter.HP = 6700;
        Karakter.MP = 350;
        Karakter.Kekuatan = 250;
        Karakter.pengurangan_MN_basic = 20;
        Karakter.pengurangan_MN_skill = 50;

        Pemain Musuh = new Pemain();
        Musuh.nama_karakter = "Eka";
        Musuh.HP = 6500;
        Musuh.MP = 270;
        Musuh.Kekuatan = 245;
        Musuh.pengurangan_MN_basic = 20;
        Musuh.pengurangan_MN_skill = 35;

        Console.WriteLine("Enter Untuk Mengadu Edwin dan Eka!!");
        Console.ReadLine();

        while (true)
        {
            if (Karakter.HP > 0)
            {
                Karakter.cetakInformasi();
                Console.WriteLine($"HP Musuh saat ini : {Musuh.HP}");
                Console.WriteLine($"Ayo {Karakter.nama_karakter} serangg!!! , jumlah mana {Karakter.MP}, Kekuatan {Karakter.Kekuatan}");
                Console.WriteLine("1.Basic Attack");
                Console.WriteLine("2.Fireball");
                Console.WriteLine("3.Ice Blast");
                Console.WriteLine("4.Heal");

                string pilihan = Console.ReadLine();

                if (pilihan == "1")
                {
                    Console.WriteLine("Menyerang lawan dengan basic attack");
                    Musuh.Serangan_lawan(Karakter.basic_attack());
                    Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh.HP}");
                } else if (pilihan == "2")// FIreball
                {
                    Console.WriteLine("Menyerang lawan dengan Fireball!!");
                    Musuh.Serangan_lawan(Karakter.gunakanSkill(1));
                    Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh.HP}");
                }else if (pilihan == "3")// Ice Blast
                {
                    Console.WriteLine("Menyerang lawan dengan Ice Blast!!");
                    Musuh.Serangan_lawan(Karakter.gunakanSkill(2));
                    Console.WriteLine($"Lawan diserang !! Hp Lawan Saat ini {Musuh.HP}");
                    Console.WriteLine($"{Musuh.nama_karakter} Melambattt !!!");
                }
                else
                {
                    Console.WriteLine("Healing");
                    Karakter.gunakanSkill(3);
                    Console.WriteLine($"Healing... HP mu saat ini {Karakter.HP}");
                }

            }
            else
            {
                Console.WriteLine("Sayang sekali kamu kalah");
                Console.WriteLine("Enter untuk menangis");
                Console.ReadLine();
                break;
            }

            if (Musuh.HP > 0)
            {
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine();

                Console.WriteLine($"{Musuh.nama_karakter} Menyerang!!");
                Thread.Sleep(2000);//delay 2 detik untuk serangan lawan

                Musuh.cetakInformasi();
                Random rnd = new Random();
                int serangan = rnd.Next(1, 3);
                if (serangan == 1)
                {
                    Karakter.Serangan_lawan(Musuh.basic_attack());
                    Console.WriteLine($"Kamu diserang Basic Attack lawann !! HPmu saat ini menjadi {Karakter.HP}");
                }
                else
                {
                    Karakter.Serangan_lawan(Musuh.gunakanSkill(1));
                    Console.WriteLine($"Kamu diserang Skill lawann !! HPmu saat ini menjadi {Karakter.HP}");
                }
                Console.WriteLine();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine($"Ayo Lawan {Musuh.nama_karakter} !!");
                Thread.Sleep(2000);//delay 2 detik untuk serangan lawan
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Hore Kamu Menang!!");
                Console.WriteLine("Enter untuk keluar");
                Console.ReadLine();
                break;
            }



        }

    }
}


