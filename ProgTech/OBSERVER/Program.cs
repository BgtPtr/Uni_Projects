
using OBSERVER;

Gondosora gondosora = new Gondosora();

Haziorvos orvos1 = new Haziorvos("Dr. Kovács");
Haziorvos orvos2 = new Haziorvos("Dr. Bihari");
gondosora.OrvosFeliratkozas(orvos1);
gondosora.OrvosFeliratkozas(orvos2);

Mentos mentos1 = new Mentos("Péter", "Budapest");
Mentos mentos2 = new Mentos("Anna", "Eger");
gondosora.MentosFeliratkozas(mentos1);
gondosora.MentosFeliratkozas(mentos2);

gondosora.MeresFunkcio();