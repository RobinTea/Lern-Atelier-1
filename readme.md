# Grobe Planung

***Robin Taing***

## 22.08.2023- Herbstferien

In der ersten Lern-Periode möchte ich verschiedene Übungen machen, um mein können zu verbessern. Ich mache mich mit dem coden vertraut und bekomme gleichzeitig Praktische Erfahrung. Die Übungen sollten simpel und einfach/schnell zu lösen sein, damit ich so viel verschiedene wie möglich machen kann. Es könnte sein das ich mich irgendwann umentscheide und ein grösseres Projekt anfange. 
Die erste Lern-Periode ist lange und ich werde mit grosser Wahrscheinlichkeit viel zu tun haben. Wenn der Fall eintreten sollte, dass ich in stress komme, erledige ich erst die Aufgaben die höchste Priorität haben befor ich weiter mit den Projekten mache. 


**29.08.2023**
- [x] Modul-Aufgaben (M431) beenden und fortfahren ( erfolgreich abgeschlossen )
- [ ] Projekt starten ( wollte nach dem ein Projekt starten, Modul-Aufträge gingen jedoch unerwartet länger )


**05.09.2023 / OPL**
- [X] Projekt aussuchen (sehr wahrscheinlich das Zahlenratenspiel)
- [X] Starten
- [X] programmieren    (siehe unten)
- [X] beenden          Ich bin viel schneller fertig geworden als gedacht


            bool raten = true;
            int versuche = 0;
            
            Random rnd = new Random();      //generiert zufällige Nummer von 1 bis 100
            int zahl = rnd.Next(1, 101);

            while (raten == true)           //while loop damit man mehrmals raten kann
            {
                Console.Write("Bitte geben sie eine Zahl ein: ");             //verlangt das der user eine zahl eingibt und wandelt sie zu einem int um
                int gerateneZahl = (Convert.ToInt32(Console.ReadLine()));

                if (zahl < gerateneZahl)                        //ist die Zahl zu gross zeigt sie diesen Text an
                {
                    Console.WriteLine("Zahl zu gross...");
                }

                if (zahl > gerateneZahl)                       //ist die Zahl zu klein zeigt sie diesen Text an
                {
                    Console.WriteLine("Zahl zu kein...");
                }

                if (zahl == gerateneZahl)                       //wurde die Zahl gefunden wird der loop geschlossen
                {
                    Console.WriteLine("Sie haben die Zahl gefunden!");
                    raten = false;
                }

                versuche++;          //versuche werden gezählt

            }

            Console.WriteLine("Es war die Zahl "+ zahl);      //löst nach dem erraten die zahl auf (schriebt sie nochmal übersichtlich hin)
            
            
            if (versuche == 1)
            {               
                Console.WriteLine("sie haben nur einen versuch gebraucht?!");    //zeigt nur an wenn man direkt die zahl erraten hat
                Console.WriteLine("Sie schummeln doch iergendwie...");
            }
            else
            {
                Console.WriteLine("sie haben " + versuche + " versuche gebraucht");    //zeigt versuche an
            }
        }         

Da ich keine weitere Ideen für ein Projekt habe, mache ich am Modul weiter.

**12.09.2023 / OPL**
- [ ] evt. ein anderes projekt finden/anfangen
- [ ] an den Modulen arbeiten wenn ich nicht nachkomme oder wenn ich nichts zu tun habe
