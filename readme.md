***Robin Taing***
## 22.08.2023 - Herbstferien
**-Einführung-**

In der ersten Lern-Periode möchte ich verschiedene Übungen machen, um mein können zu verbessern. Ich mache mich mit dem coden vertraut und bekomme gleichzeitig Praktische Erfahrung. Die Übungen sollten simpel und einfach/schnell zu lösen sein, damit ich so viel verschiedene wie möglich machen kann. Es könnte sein das ich mich irgendwann umentscheide und ein grösseres Projekt anfange. 
Die erste Lern-Periode ist lange und ich werde mit grosser Wahrscheinlichkeit viel zu tun haben. Wenn der Fall eintreten sollte, dass ich in stress komme, erledige ich erst die Aufgaben die höchste Priorität haben befor ich weiter mit den Projekten mache. 

_____________________________________________________________________________________________________________________________________________________________________________

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
      Ich war unentschlossen und konnte mich nicht für eine Projekt Idee entacheiden. Der Hauptgrund ist, dass ich noch nicht die richtigen Kentnisse habe. Ich denke das ic
      erst nach den Herbstferien mit Projekten fortfahre. Es kann sein das ich mich plötzlich unentscheide und ein Projekt starte.
- [x] an den Modulen arbeiten wenn ich nicht nachkomme oder wenn ich nichts zu tun habe
      Ich habe an den Modulen gearbeitet und bin weitergekommen. Ich fand es mühsam das ein grosser Teil nicht mit Moodle-Tests bewertet wird sondern mit der Abgabe der
      Dokumenten. Ich versuche sie vorsichtig und Detailiert zu machen, was sehr Zeit aufwändig ist. Ich bin zwar weiter gekommen aber ich habe das Gefühl, dass ich immer
      noch nicht dort bin wo ich sein sollte.

**19.09.2023**
- [X] An den Modul 431 (bis 1720) weiterarbeiten.
      (so das die mindestziele und die erweitertenziele gemacht sind und das ich an den expertenziele arbeiten kann)
      Ich konnte recht gut arbeiten 1718 und 1720 beenden und bin nun fast dort, wo ich sein möchte.
      ich kam gut voran auch wenn ich alles recht detailiert gemacht habe. das nächste mal werde ich mit 100%er Wahrscheinlichkeit ein Projekt anfangen.

**26.09.2023**
Taschenrechenr programmieren (nur in der Konsole)
- [x] tutorial suchen (Link: https://www.youtube.com/watch?v=VvA28TwDE1A) Ich hätte es auch ohne machen können. Ich habe erst gemerkt wie simpel es ist als ich schon am 
      programmieren war.
- [x] programmieren (Im Ordner "Taschenrechner") 
- [ ] verstehen/lernen
      Es gab neue Begriffe die ich noch nie gehört habe z.B. Console.ReadKey(); Envirement.Exit(0); double wert = double.Parse(Console.ReadLine());
      Ich habe auch erkannt, dass etwas dividiert durch 0, immer 8 gibt(steht wohl für unendlich). Ich habe dann hinzugefügt das es "infinity" anzeigt.
      
# Refelktion
In dieser Lernperiode musste ich mich an einige neue Dinge gewöhnen. Ich war überrascht, dass das Lernatelier so flexibel ist. Man hatte die Freiheit, an den Modulen zu arbeiten. Man kann auch seine Projekte frei wählen. Das Problem war, dass mir keine Ideen gekommen sind, was ich machen könnte. Dies hat mich leicht gehindert. Aus diesem Grund habe ich am Mosul 431 weitergearbeite und bin dank dem gut vorangekommen. Trotzdem habe ich zwei Programmierprojekte abgeschlossen. Ich habe den tipp bekommen das ich ein Zahlrate Spiel machen sollte. Ich habe dann Dinge gebraucht die ich gelernt hatte, was ein gutes Gefühl ist. Es ist gut zu wissen das man die Dinge, die man lernt auch gebraucht wird. Das andere war ein Taschenrechner. Meine Kollegen haben mich inspiriert. Sie haben es in einem Fenster aufpoppen lassen die sie iergendwie mit win forts gemacht haben. Ich hingegen habe es in der Konsole gemacht, aber nun weiss ich das ich das mit dem Fenster auch machen möchte. Beim Anschauen des Tutorials habe ich neue begriffe gelernt die ich noch nicht kannte.

Abgeschlossene Projekte:
- Taschenrechner
- Zhalerraten Spiel

# VBV
**(Verbesserungs Vorschläge für mich selbst)**
Ich möchte mich mehr Inspirieren lassen. Mir fehlten Ideen und Ich war einfach nicht daran gewöhnt, so viel Freiheit zu haben. Ich habe micih mit einem Kollegen unterhalten und er hat gemeint ich solle doch mehr im Internet nachschauen da wir sowieso noch nicht so viel können (noch nicht gelernt haben). Ich werde Herausfordernde Projekte finden die schwieriger sind als die, die ich bereits gemacht habe. 
