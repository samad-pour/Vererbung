# 5.6	Vererbung
•	**Doppelpunkt**: Dadurch wird festgelegt, dass die Klasse PKW alle Elemente von der Klasse Fahrzeug erbt.

•	**base()**: Der andere Konstruktor benötigt eine string-Variable und zwei int-Variablen. Zwei der übergebenen Werte werden mithilfe von base() an die Basisklasse weitergereicht, dabei muss der passende Konstruktor aufgerufen werden.

•	Der dritte Wert wird in der Klasse PKW zum Vorbesetzen der eigenen Eigenschaft der Klasse PKW genutzt.

•	**GetType()**: Zur Verdeutlichung wird in der Ausgabemethode ToString() mithilfe der Methode GetType() jeweils zusätzlich die Klasse des Objekts ausgegeben.

```
class PKW : Fahrzeug
{
	…
	public PKW(string b, int g, int i) : base(b, g)
	{
		insassen = i;
		insassen.GetType();
	}
}

```
