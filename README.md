# Labb_OOP_PersonRegistry
Detta är en labb i kursen Grundläggande objektorienterad programmering. Gjord 2022-11-28.

# Beskrivning

- SCENARIO
I denna laboration ska en lista med personer skapas. Listan kan bestå av tre olika typer typer: man, kvinna eller barn.



Del 1 - Listan
Skapa ett program som visar en lista med personer
· Personer, male eller female ska kunna läggas till i listan med för- och efternamn
· Ett prefix Male/Female skall visa könet på personen i listan
· Personer i listan ska kunna raderas
· Listan ska gå att sortera på efternamn sedan på förnamn. GÖR SÅ ATT LISTAN SKA AUTOMATISKT SORTERAS VARJE GÅNG MAN LÄGGER TILL/TAR BORT EN PERSON
· LISTAN MÅSTE VARA AV TYPEN PERSON
· FÖR ATT HÄMTA NAMN MÅSTE EN METOD GETNAME ANROPAS PÅ VARJE OBJEKT (PERSON MÅSTE HA EN ABSTRAKT METOD: GETNAME)
· För att sorteringsfunktionen ska fungera, ska basklassen Person implementera interfacet IComparable
· Personer ska kunna slås samman med en merge-funktion

Figur 1: Personlista
Klasser (personer)
Klasser som ska finnas är Person, Male, Female och Child. Klassen Person ska vara basklass för de övriga klasserna och det ska inte vara möjligt att skapa en instans av basklassen. Basklassen ska implementera en konstruktor där man kan skicka in förnamn och efternamn.

Merge
Om två, och endast två personer, av olika kön är markerade (highlighted) när man klickar på Merge, så skall en Child skapas. Child ska få förnamn från Female och efternamn från Male och namnet ska föregås av Child (istället för Mr eller Miss)

Del 3 – Sökfunktion (väl godkänd)
Skapa funktionalitet för instant search för att lätt hitta åt personer i listan
· Skall visa resultatet direkt (instant search result)
· Sökfunktionen ska fungera på både för och efternamn
· Gemener eller versaler ska inte ha betydelse för söknin
