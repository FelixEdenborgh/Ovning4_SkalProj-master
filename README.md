Frågor:

1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion:
   Det funkar så här t ex att jag har en method vid namn MyMethod() som har en int a = 10, och en int b = 15
   samt ett object. Och då de lokala variablerna a och b som är primitiva datatyper "int" kommer att allokeras och lagras direkt på stacken. Samma med dess världen (10 och 15) som också lagras på stacken.
   Då deras livstid är begränsad till när metoden "körs".
   När du skapar ett object som t ex MyClass myObject = new MyClass(); så händer 2 saker. Första är att den allokeras och lagras på heapen. 2. En referens variable myObject skapas på stacken. Denna variablen pekar på objectets plats på heapen.
   Även om myObjects referens finns på stacken så pekar den till objektets faktiska data som finns lagrad på heapen.
   ![mspaint_0ImKmFcIq0](https://github.com/FelixEdenborgh/Ovning4_SkalProj-master/assets/31070311/a7c465b0-af46-41e3-9bff-419f09106edc)



3. Vad är Value Types respektive Reference Types och vad skiljer dem åt?
   Value types: Value types lagrar data direkt och inkluderar de primitiva datatyperna samt strukturer (structs) och enum-typen.
   När de tilldelar en value type till en annan variabel, kopieras värdet direkt. Det betyder att den ursprungliga och den nya variablen opererar på två oberoende datavärden.
   Ändringar till det ena världet påverkar inte det andra. Exempel på value types är: (int, double, float, bool, chat, (Strukturer definierade med struct) och enum-typen).
   Reference types: Reference types lagrar referenser till den faktiska datan senare än datan själv. När du tilldelar en reference type till en annan variabel, kopieras referensen, och båda variablerna pekar då på samma object i minnet.
   Ändringar via en av referenserna reflekteras därmed överallt där referensen används.
   Exempel på reference types: Klasser( definerade med class), Arrays, Delegater, string, object och interface.


4. Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?
   Första metoden använder: Value types:
   
   ![opera_Ab59V7QiUD](https://github.com/FelixEdenborgh/Ovning4_SkalProj-master/assets/31070311/e1034d05-b12e-44ab-98ff-57a992b08bfc)


   Där både x och y är value types. När y tilldelas värdet av x kopieras värdet av x till y senare ändringar på y påverkar inte x eftersom de är helt separata variabler som lagrar sina värden direkt.

   Andra metohden använder: Reference types:
   ![opera_OsrsIufC5u](https://github.com/FelixEdenborgh/Ovning4_SkalProj-master/assets/31070311/f766eb91-b90b-4312-89df-9cd54ce753ad)


   I detta fallet är x och y reference types vilket betyder att de lagrar referense till object i minnet på heapen.
   När y tilldelas x börjar de peka på samma object. Så när y.MyValue sätts till 4 påverkas objektet som x också pekar på och x.MyValue blir därmed också 4.

   Sammanfattning:
   Skillnaden i beteende mellan dessa två metoder illustrerar skillnaden mellan value types och reference types:
   För value types (int i det första exemplet), kopieras värdet. Så när du modifierar en kopia, påverkas inte det ursprungliga värdet.
   För reference types (objektet MyInt i det andra exemplet), kopieras referensen till objektet. Så när du modifierar objektet via en referens, påverkas alla referenser som pekar på det objektet.





Övning 3: ExamineStack()
   Stackar påminner om köer, men en stor skillnad är att stackar använder sig av Först In Sist Ut (FILO) principen. Alltså gäller att det element som stoppas in först (push) är det som kommer tas bort sist (pop).
   5/7
   1. Simulera ännu en gång ICA-kön på papper. Denna gång med en stack. Varför är det inte så smart att använda en stack i det här fallet?
      Problemet är att om man kör som en ICA kö med stack så kommer det vara att den som kommer först till kön kommer längst bak och den som kommer sist
      får hjälp först.
      Och det kommer aldrig funka då man själv vill inte vänta längre varje gång det kommer en ny person som vill betala.
      Utan man vill hälre vara att den som kommer först får hjälp först.
      Se bild för mer info:
      
      ![mspaint_meux5IZOcL](https://github.com/FelixEdenborgh/Ovning4_SkalProj-master/assets/31070311/68d91aff-8f3f-473b-90da-e64097b53068)



   
