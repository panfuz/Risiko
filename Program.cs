Continente c1 = new Continente("c1", "Nord America", new List<Territorio>() { });
Continente c2 = new Continente("c2", "Sud America", new List<Territorio>() { });
Continente c3 = new Continente("c3", "Africa", new List<Territorio>() { });
Continente c4 = new Continente("c4", "Europa", new List<Territorio>() { });
Continente c5 = new Continente("c5", "Asia", new List<Territorio>() { });
Continente c6 = new Continente("c6", "Oceania", new List<Territorio>() { });

Obiettivo o1 = new Obiettivo("o1", "Conquista la totalità di Asia e America del Sud");
Obiettivo o2 = new Obiettivo("o2", "Conquista la totalità di Oceania e Nord America");
Obiettivo o3 = new Obiettivo("o3", "Conquista la totalità di Africa, Europa e un continente a scelta");
Obiettivo o4 = new Obiettivo("o4", "Annienta le armate rosse, se sei tu o vengono annientate da un altro giocatore conquista 24 territori");
Obiettivo o5 = new Obiettivo("o5", "Annienta le armate nere, se sei tu o vengono annientate da un altro giocatore conquista 24 territori");
Obiettivo o6 = new Obiettivo("o6", "Conquista la totalità di Oceania, Asia e America del Sud");

Giocatore g1 = new Giocatore("g1", "Franco");
Giocatore g2 = new Giocatore("g2", "Stino");
Giocatore g3 = new Giocatore("g3", "Lagipe");

Esercito e1 = new Esercito("e1", "g1", new List<int>() { });
Esercito e2 = new Esercito("e2", "g2", new List<int>() { });
Esercito e3 = new Esercito("e3", "g3", new List<int>() { });
