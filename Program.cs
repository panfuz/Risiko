
Territorio american1 = new Territorio("american1", "Groenlandia", "c1", "cavaliere");
Territorio american2 = new Territorio("american2", "Alaska", "american", "c1");
Territorio american3 = new Territorio("american3", "Territori Nord-Ovest", "c1", "cavaliere");
Territorio american4 = new Territorio("american4", "Alberta", "c1", "cavaliere");
Territorio american5 = new Territorio("american5", "Ontario", "c1", "cavaliere");
Territorio american6 = new Territorio("american6", "Quebec", "c1", "cavaliere");
Territorio american7 = new Territorio("american7", "USA Orientali", "c1", "cavaliere");
Territorio american8 = new Territorio("american8", "America Centrale", "c1", "cavaliere");
Territorio american9 = new Territorio("american9", "USA Occidentali", "c1", "cavaliere");

Territorio americas1 = new Territorio("americas1", "Argentina", "c2", "cavaliere");
Territorio americas2 = new Territorio("americas2", "Brasile", "c2", "cavaliere");
Territorio americas3 = new Territorio("americas3", "Perù", "c2", "cavaliere");
Territorio americas4 = new Territorio("americas4", "Venezuela", "c2", "cavaliere");

Territorio europa1 = new Territorio("europa1", "Islanda", "c4", "cavaliere");
Territorio europa2 = new Territorio("europa2", "Gran Bretagna", "c4", "fante");
Territorio europa3 = new Territorio("europa3", "Scandinavia", "c4", "fante");
Territorio europa4 = new Territorio("europa4", "Europa Occidentale", "c4", "fante");
Territorio europa5 = new Territorio("europa5", "Europa Settentrionale", "c4", "fante");
Territorio europa6 = new Territorio("europa6", "Europa Meridionale", "c4", "fante");
Territorio europa7 = new Territorio("europa7", "Ucraina", "c4", "fante");

Territorio africa1 = new Territorio("africa1", "Egitto", "c3", "fante");
Territorio africa2 = new Territorio("africa2", "Congo", "c3", "fante");
Territorio africa3 = new Territorio("africa3", "Madagascar", "c3", "fante");
Territorio africa4 = new Territorio("africa4", "Africa del Nord", "c3", "fante");
Territorio africa5 = new Territorio("africa5", "Africa del Sud", "c3", "fante");
Territorio africa6 = new Territorio("africa6", "Africa Orientale", "c3", "fante");

Territorio asia1 = new Territorio("asia1", "Medio Oriente", "c5", "fante");
Territorio asia2 = new Territorio("asia2", "Urali", "c5", "fante");
Territorio asia3 = new Territorio("asia3", "Afganistan", "c5", "cannone");
Territorio asia4 = new Territorio("asia4", "India", "c5", "cannone");
Territorio asia5 = new Territorio("asia5", "Siam", "c5", "cannone");
Territorio asia6 = new Territorio("asia6", "Cina", "c5", "cannone");
Territorio asia7 = new Territorio("asia7", "Mongolia", "c5", "cannone");
Territorio asia8 = new Territorio("asia8", "Jacuzia", "c5", "cannone");
Territorio asia9 = new Territorio("asia9", "Čita", "c5", "cannone");
Territorio asia10 = new Territorio("asia10", "Kamchatka", "c5", "cannone");
Territorio asia11 = new Territorio("asia11", "Giappone", "c5", "cannone");
Territorio asia12 = new Territorio("asia12", "Siberia", "c5", "cannone");

Territorio oceania1 = new Territorio("oceania1", "Nuova Guinea", "c6", "cannone");
Territorio oceania2 = new Territorio("oceania1", "Indonesia", "c6", "cannone");
Territorio oceania3 = new Territorio("oceania1", "Australia Orientale", "c6", "cannone");
Territorio oceania4 = new Territorio("oceania1", "Australia Occidentale", "c6", "cannone");


List<Territorio> americaNord = new List<Territorio>() {
    american1,
    american2,
    american3,
    american4,
    american5,
    american6,
    american7,
    american8,
    american9
};

List<Territorio> americaSud = new List<Territorio>() {
    americas1,
    americas2,
    americas3,
    americas4
};

List<Territorio> africa = new List<Territorio>() {
    africa1,
    africa2,
    africa3,
    africa4,
    africa5,
    africa6
};

List<Territorio> europa = new List<Territorio>() {
    europa1,
    europa2,
    europa3,
    europa4,
    europa5,
    europa6,
    europa7
};

List<Territorio> asia = new List<Territorio>() {
    asia1,
    asia2,
    asia3,
    asia4,
    asia5,
    asia6,
    asia7,
    asia8,
    asia9,
    asia10,
    asia11,
    asia12
};

List<Territorio> oceania = new List<Territorio>() {
    oceania1,
    oceania2,
    oceania3,
    oceania4
};

List<Territorio> territori = new List<Territorio>()
{
    american1,american2,american3,american4,american5,american6, american7,american8,american9,

    americas1,americas2,americas3,americas4,

    africa1, africa2, africa3, africa4, africa5, africa6,

    europa1,europa2,europa3, europa4, europa5, europa6, europa7,

    asia1, asia2, asia3, asia4, asia5, asia6,  asia7,  asia8,  asia9,  asia10,  asia11,

    oceania1, oceania2, oceania3, oceania4
};


Obiettivo o1 = new Obiettivo("o1", "Conquista la totalità di Asia e America del Sud");
Obiettivo o2 = new Obiettivo("o2", "Conquista la totalità di Oceania e Nord America");
Obiettivo o3 = new Obiettivo("o3", "Conquista la totalità di Africa, Europa e un continente a scelta");
Obiettivo o4 = new Obiettivo("o4", "Annienta l'esercito 1, se sei tu o vengono annientate da un altro giocatore conquista 24 territori");
Obiettivo o5 = new Obiettivo("o5", "Annienta l'esercito 3, se sei tu o vengono annientate da un altro giocatore conquista 24 territori");
Obiettivo o6 = new Obiettivo("o6", "Conquista la totalità di Oceania, Asia e America del Sud");

List<Obiettivo> obiettivi = new List<Obiettivo>()
{
    o1, o2, o3, o4, o5, o6
};


Esercito e1 = new Esercito("e1");
Esercito e2 = new Esercito("e2");
Esercito e3 = new Esercito("e3");

List<Esercito> eserciti = new List<Esercito>()
{
    e1, e2, e3
};



Random random = new Random();

//inserimento 14 territori esercito 1

List<Territorio> territoriCasualiE1 = new List<Territorio>();
for (int i = 0; i < 14; i++)
{
    int index = random.Next(territori.Count);
    Territorio territorioCasuale = territori[index];
    territoriCasualiE1.Add(territorioCasuale);
    territori.RemoveAt(index);
}

foreach (Territorio territorio in territoriCasualiE1)
{
    e1.InserisciTerritorio(territorio);
}
e1.StampaTerritori();




//inserimento 14 territori esercito 2
List<Territorio> territoriCasualiE2 = new List<Territorio>();

for (int i = 0; i < 14; i++)
{
    int index = random.Next(territori.Count);
    Territorio territorioCasuale = territori[index];
    territoriCasualiE2.Add(territorioCasuale);
    territori.RemoveAt(index);
}

foreach (Territorio territorio in territoriCasualiE2)
{
    e2.InserisciTerritorio(territorio);
}

e2.StampaTerritori();





//inserimento 14 territori esercito 3
List<Territorio> territoriCasualiE3 = new List<Territorio>();

for (int i = 0; i < 13; i++)
{
    int index = random.Next(territori.Count);
    Territorio territorioCasuale = territori[index];
    territoriCasualiE3.Add(territorioCasuale);
    territori.RemoveAt(index);
}

foreach (Territorio territorio in territoriCasualiE3)
{
    e3.InserisciTerritorio(territorio);
}
e3.StampaTerritori();




//distribuzione obiettivi casualmente
e1.AggiungiObiettivo(obiettivi);
e2.AggiungiObiettivo(obiettivi);
e3.AggiungiObiettivo(obiettivi);


//aggiunge confini
foreach (Territorio territorio in territori)
{
    territorio.AggiungiTerritoriCasuali(territori);
}


// Stampa dei territori e dei loro territori confinanti
foreach (Territorio territorio in territori)
{
    Console.WriteLine("Territorio: " + territorio.Nome);
    Console.WriteLine("Territori confinanti:");
    foreach (Territorio territorioConfinante in territorio.TerritoriConfinanti)
    {
        Console.WriteLine("- " + territorioConfinante.Nome);
    }
    Console.WriteLine();
}

//aggiunta 35 truppe iniziali a ogni esercito e aggiunta truppe a ogni territorio

e1.AggiungiTruppeIniziali();
e2.AggiungiTruppeIniziali();
e3.AggiungiTruppeIniziali();


//stampa delle truppe assegnate a ogni territorio
Console.WriteLine("Truppe nell'esercito 1:");
foreach (Territorio territorio in e1.TerritoriContenuti)
{
    Console.WriteLine("Territorio: " + territorio.Nome);
    foreach (Truppa truppa in territorio.Truppe)
    {
        Console.WriteLine("ID: " + truppa.id + ", ID Esercito: " + truppa.id_esercito);
    }
    Console.WriteLine();
}


Console.WriteLine("Truppe nell'esercito 1:");
foreach (Territorio territorio in e1.TerritoriContenuti)
{
    Console.WriteLine("Territorio: " + territorio.Nome);
    foreach (Truppa truppa in territorio.Truppe)
    {
        Console.WriteLine("ID: " + truppa.id + ", ID Esercito: " + truppa.id_esercito);
    }
    Console.WriteLine();
}


Console.WriteLine("Truppe nell'esercito 3:");
foreach (Territorio territorio in e3.TerritoriContenuti)
{
    Console.WriteLine("Territorio: " + territorio.Nome);
    foreach (Truppa truppa in territorio.Truppe)
    {
        Console.WriteLine("ID: " + truppa.id + ", ID Esercito: " + truppa.id_esercito);
    }
    Console.WriteLine();
}
