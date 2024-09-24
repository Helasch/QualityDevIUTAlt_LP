using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualite_Dev_TP1
{
    public class Media
    {
        public string Title;
        public int Ref_Num;
        public int NB_Ex_Disp;

        public void AfficherInfos()
        {
            System.Console.WriteLine("Titre =" + Title);
            System.Console.WriteLine("Numéro de réference =" +  Ref_Num);
            System.Console.WriteLine("Nombre d'exemplaire disponible =" +  NB_Ex_Disp);
        }

        public static Media operator +(Media media, int nbExemplaire)
        {
            media.NB_Ex_Disp += nbExemplaire;
            return media;
        }

        public static Media operator -(Media media,int nbExemplaire)
        {
            if media.NB_Ex_Disp -= nbExemplaire < 0:
            {
                throw new InvalidOperationException("Impossible de faire...");
            }
            media.NB_Ex_Disp -= nbExemplaire;
            return media;
        }
    }

    public class livre : Media 
    {
        public string Author;
        public void AfficherInfos()
        {
            System.Console.WriteLine("Auteur =" + Author);
        }
    }

    public class DVD : Media
    {
        public int Duration;
        public void AfficherInfos()
        { 
            System.Console.WriteLine("Durée =" +  Duration); 
        }
    }

    public class CD : Media
    {
        public string artist;
        public void AfficherInfos()
        {
            System.Console.WriteLine("Artiste =" + artist);
        }

    }
}
