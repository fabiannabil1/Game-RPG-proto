using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RPG
{
    public interface RPG
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Kekuatan { get; set; }
        public int pengurangan_MN_basic { get; set; }
        public int pengurangan_MN_skill { get; set; }



        int basic_attack();
        int Serangan_lawan(int damage);
        int gunakanSkill(int serangan);
        void cetakInformasi();

    }
    public abstract class Karakter : RPG
    {
        public string nama_karakter { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public int Kekuatan { get; set; }
        public int pengurangan_MN_basic { get; set; }
        public int pengurangan_MN_skill { get; set; }

        public abstract int basic_attack();
        public abstract int Serangan_lawan(int damage);
        public abstract int gunakanSkill(int skill);
        public abstract void cetakInformasi();


    }

    public class Pemain : Karakter
    {
        public override int gunakanSkill(int skill)
        {
            if (skill==1)
            {
                if (MP > pengurangan_MN_skill)
                {
                    MP -= pengurangan_MN-skill;
                    return kekuatan * 2;
                ) else
                {
                return 0;
                }
                
            } else if (skill == 2) // Ice Blast
            {
                if (MP > pengurangan_MN_skill)
                {
                    MP -= (pengurangan_MN-skill*2);
                    return kekuatan * 3;
                ) else
                {
                return 0;
                }
            }else // Healing
            {
                HP += 200;
                MP += 30;
                return 0;
            }
            }
            else
            {
                return 0;
            }
           
        }
        public override int basic_attack()
        {
            if (MP > pengurangan_MN_basic)
            {
                MP = MP - pengurangan_MN_basic;
                return Kekuatan;
            }
            else
            {
                return 0;
            }

        }

        public override int Serangan_lawan(int damage)
        {
            HP -= damage;
            return HP;
        }
        public override void cetakInformasi()
        {
            Console.WriteLine($"karakter           : {nama_karakter}");
            Console.WriteLine($"HP Tersisa         : {HP}");
            Console.WriteLine($"Mana Power tersisa : {MP}");
        }
    }
}
