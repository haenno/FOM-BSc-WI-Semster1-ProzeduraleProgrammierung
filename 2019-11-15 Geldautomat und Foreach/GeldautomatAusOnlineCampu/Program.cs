using System;
using System.Collections.Generic;

namespace GeldautomatAusOnlineCampu
{
    class Program
    {

        // LogLevel 1 = alle Aufrufe und Ergebnisse aus main[]
        // LogLevel 2 = alles wichtige aus den Metoden 
        // LogLevel 9 = verbose

        static List<string> EventLog = new List<string>();
        static string pathLog = @"C:\Users\haenno\Desktop\logChron.txt";
        static string pathSortedLog = @"C:\Users\haenno\Desktop\logSorted.txt";


        static void LogAdd(string Event, int LogLevel)
        {
            string LogStr = "LogLevel " + Convert.ToString(LogLevel).PadLeft(3, '0') + " :: " + DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss") + " :: " + Event;
            EventLog.Add(LogStr);
            LogStr = LogStr +"\n";
            System.IO.File.AppendAllText(pathLog,LogStr);
        }

        static string CheckForPIN(string validPIN)
        {
            int tries = 0;
            string pin;
            do
            {
                Console.Write("Bitte PIN eingeben: ");
                pin = Console.ReadLine();
                tries++;
            }
            while (pin != validPIN && tries < 3);

            return pin;
        }
        static void CheckoutMoney(int amount)
        {
            //Stückelung berechnen
            int Notetwohundret = amount / 200;
            Console.WriteLine("Sie bekommen 200 Euro " + Notetwohundret + " Schein(e)");
            LogAdd("Es wurden " + Notetwohundret + " 200 Euro Schein(e) ausgegeben", 9);
            int Rest1 = amount - (Notetwohundret * 200);
            int Noteonehundret = Rest1 / 100;
            Console.WriteLine("Sie bekommen 100 Euro " + Noteonehundret + " Schein(e)");
            LogAdd("Es wurden " + Noteonehundret + " 100 Euro Schein(e) ausgegeben", 9);
            int Rest2 = amount - (Notetwohundret * 200) - (Noteonehundret * 100);
            int Notefifty = Rest2 / 50;
            Console.WriteLine("Sie bekommen 50 Euro " + Notefifty + " Schein(e)");
            LogAdd("Es wurden " + Notefifty + " 50  Euro Schein(e) ausgegeben", 9);
            int Rest3 = amount - (Notetwohundret * 200) - (Noteonehundret * 100) - (Notefifty * 50);
            int Notetwenty = Rest3 / 20;
            Console.WriteLine("Sie bekommen 20 Euro " + Notetwenty + " Schein(e)");
            LogAdd("Es wurden " + Notetwenty + " 20 Euro Schein(e) ausgegeben", 9);
            int Rest4 = amount - (Notetwohundret * 200) - (Noteonehundret * 100) - (Notefifty * 50) - (Notetwenty * 20);
            int Noteten = Rest4 / 10;
            Console.WriteLine("Sie bekommen 10 Euro " + Noteten + " Schein(e)");
            LogAdd("Es wurden " + Noteten + " 10  Euro Schein(e) ausgegeben", 9);
            int Rest5 = amount - (Notetwohundret * 200) - (Noteonehundret * 100) - (Notefifty * 50) - (Notetwenty * 20) - (Noteten * 10);
            int Notefive = Rest5 / 5;
            Console.WriteLine("Sie bekommen 5 Euro " + Notefive + " Schein(e)");
            LogAdd("Es wurden " + Notefive + " 5 Euro Schein(e) ausgegeben", 9);

            //Auszahlung vornehmen
            Console.WriteLine("Bitte Geld entnehmen\n");
            LogAdd("Aufforderung Geldentnahme", 2);
        }

        static int AskForValidAmount()
        {
            LogAdd("Abfrage Betrag", 2);
            int amount;

            do
            {
                Console.Write("Bitte Betrag eingeben: ");
                LogAdd("Eingabezeile ausgegeben", 9);
                amount = Convert.ToInt32(Console.ReadLine());
            } while (amount % 5 != 0);
            LogAdd("Abfragemetode für Betrag verlassen", 9);
            return amount;
        }

        static void Main(string[] args)
        {



            Console.WriteLine("Lade Software...");

            // Endlosschleife für die Geldautomaten-Software
            while (true)
            {
                Console.WriteLine("Herzlich Willkommen!");
                LogAdd("Starte Durchlauf",1);

                // Lese Kartendaten
                bool isCardValid = true;    // ReadCardFromReader();

                if (isCardValid)
                {
                    string pin = CheckForPIN("1234");

                    if (pin == "1234")
                    {
                        LogAdd("In PIN Abfrage",1);
                        bool isForeignCard = false; // ReadCardIssuer();
                        float kontostand = 5000.0f; // ReadBalanceFromServer();

                        // Betrag in 5er Schritten
                        int amount;
                        float zielbetrag;
                        do
                        {
                         
                            amount = AskForValidAmount();
                            LogAdd("Abfrage Betrag",1);

                            if (isForeignCard)
                            {
                                zielbetrag = amount * 1.05f;
                                LogAdd("Ist Fremdkarte!",1);
                            }
                            else
                            {
                                zielbetrag = amount;
                                LogAdd("Ist keine Fremdkarte!",1);
                            }

                            if (kontostand < zielbetrag)
                            {
                                Console.WriteLine("Der Kontostand ist nicht ausreichend!");
                                LogAdd("Kunde ist Pleite",1);
                            }
                        }
                        while (kontostand < zielbetrag);


                        CheckoutMoney(amount);
                        LogAdd("Geldausgabe erfolgt",1);
                    }
                    else
                    {
                        Console.WriteLine("Falsche PIN; Karte wird gesperrt");
                        LogAdd("Abbruch aufgrund falscher PIN",1);
                        // BlockCard();
                    }
                }

                // Karte ausgeben

                
                
                //EventLog ausgeben:
                Console.WriteLine("\n\n\nEnde der Software.\n\n**************************************\n\n\nAusgabe Eventlog nach LogLevel:\n");
                LogAdd("Stortierung und Ausgabe LogDaten auf Console", 2);
                LogAdd("Ende Logging und Durchlauf der Software", 1);
                EventLog.Sort();
                foreach (string Event in EventLog)
                {
                    Console.WriteLine(Event);
                }
                Console.WriteLine("\n\n\nTaste für Neustart...");  Console.ReadLine();


                //if (!System.IO.File.Exists(pathSortedLog)) { System.IO.File.Create(pathSortedLog); }
                
                System.IO.File.AppendAllLines(pathSortedLog, EventLog);
                
                EventLog.Clear();
                Console.Clear();

            }
        }
    }
}
