using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RitariPeli;

namespace Ritaripeli
{
    internal class Kauppa
    {
        // Kauppa-luokka, jossa pelaaja voi ostaa ruokaa
        public void OstaRuoka(Player player)
            {
                int ruoanHinta = 5;
                if (player.currentWealth >= ruoanHinta)
                {
                    player.currentWealth -= ruoanHinta;
                    player.currentHealth += 5; // Ruoka lisää osumapisteitä
                    Console.WriteLine("Ostit ruokaa! Osumapisteesi lisääntyivät.");
                }
                else
                {
                    Console.WriteLine("Sinulla ei ole tarpeeksi kultarahaa ostamaan ruokaa.");
                }
            // voit ostaa myös parempia aseita ja nuolia, mutta se vaatii enemmän kultaa ja lisää osumapisteitä
            int aseenHinta = 10;
            if (player.currentWealth >= aseenHinta)
            {
                player.currentWealth -= aseenHinta;
                player.currentHealth += 10; // Ase lisää osumapisteitä
                Console.WriteLine("Ostit paremman aseen! Osumapisteesi lisääntyivät.");
            }
            else
            {
                Console.WriteLine("Sinulla ei ole tarpeeksi kultarahaa ostamaan parempaa asetta.");
            }
                int nuolienHinta = 3;
                if (player.currentWealth >= nuolienHinta)
                {
                    player.currentWealth -= nuolienHinta;
                    player.currentHealth += 3; // Nuoli lisää osumapisteitä
                    Console.WriteLine("Ostit nuolia! Osumapisteesi lisääntyivät.");
                }
                else
                {
                    Console.WriteLine("Sinulla ei ole tarpeeksi kultarahaa ostamaan nuolia.");
            }
        }
    }
}
