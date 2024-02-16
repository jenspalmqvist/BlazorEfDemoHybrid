# BlazorEfDemoHybrid


Formul�r i Blazor:

<EditForm> �r en inbyggd komponent som kommer fr�n AspNetCores komponentbibliotek,
den bygger vidare p� ett vanligt html-<form> men inneh�ller ocks� funktioner f�r 
automatisk validering av datan utifr�n vilken Model vi s�tter i <EditForm Model="">.


OnValidSubmit kollar om input st�mmer �verens med modellen innan data skickas iv�g, om det �r ok s� skickas den.
OnInvalidSubmit g�r samma sak, men skickar inte iv�g datan utan r�dmarkerar de f�lt som saknar eller inneh�ller felaktig data.

Valideringen f�r funktionerna h�r ovan sker INNAN de anropas, dvs. formul�ret kollar om datan �r korrekt
och v�ljer vilken av funktionerna som ska anropas utifr�n det.

OnSubmit funkar som en vanlig onsubmit i html-<form>, vi beh�ver validera manuellt om vi kr�ver det.

