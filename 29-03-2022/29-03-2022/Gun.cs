using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_03_2022
{
    public class Gun
    {
        public int CurrentBullet;
        public int Magazine;
        public int MaxBulletCount;

        public Gun(int currentBullet,int magazine,int maxBulletCount)
        {
            CurrentBullet = currentBullet;
            Magazine = magazine;
            MaxBulletCount = maxBulletCount;
        }
        public void Fire(string rejim)
        {
            if(rejim == "Single")
            {
                CurrentBullet--;
            }
            else if (rejim == "Automatic")
            {
                CurrentBullet = 0;
            }
            Console.WriteLine($"Qalan gulle: {CurrentBullet}");
        }

        public void Reload(int bullet)
        {
            if(bullet <= MaxBulletCount)
            {
                int BulletReload = CurrentBullet + bullet;
                if (BulletReload <= Magazine)
                {
                    CurrentBullet += bullet;
                    MaxBulletCount -= bullet;
                    Console.WriteLine($"Daragdaki gullelerin sayi : {CurrentBullet} Bizde olan gullelerin sayi: {MaxBulletCount}");
                }
                else
                {
                    int extraBullet = BulletReload - Magazine;
                    CurrentBullet = Magazine;
                    MaxBulletCount -= bullet;
                    MaxBulletCount += extraBullet;
                    Console.WriteLine($"Daragda qalan gulle :{CurrentBullet} Elave qalan gullelerin sayi:{extraBullet} Bizde olan gullelerin sayi:{MaxBulletCount}");
                }
            }
        }
    }
}
