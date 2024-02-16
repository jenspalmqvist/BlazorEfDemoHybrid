# BlazorEfDemoHybrid


Formulär i Blazor:

<EditForm> är en inbyggd komponent som kommer från AspNetCores komponentbibliotek,
den bygger vidare på ett vanligt html-<form> men innehåller också funktioner för 
automatisk validering av datan utifrån vilken Model vi sätter i <EditForm Model="">.


OnValidSubmit kollar om input stämmer överens med modellen innan data skickas iväg, om det är ok så skickas den.
OnInvalidSubmit gör samma sak, men skickar inte iväg datan utan rödmarkerar de fält som saknar eller innehåller felaktig data.

Valideringen för funktionerna här ovan sker INNAN de anropas, dvs. formuläret kollar om datan är korrekt
och väljer vilken av funktionerna som ska anropas utifrån det.

OnSubmit funkar som en vanlig onsubmit i html-<form>, vi behöver validera manuellt om vi kräver det.

