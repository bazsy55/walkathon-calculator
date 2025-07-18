# Walkathon Calculator

Ez az alkalmaz�s a [KlikkerTV](https://www.twitch.tv/klikkertv) walkathon stream esem�ny�hez k�sz�lt.  
Seg�ts�g�vel val�s id�ben k�vethet� �s sz�molhat� az �sszegy�lt kilom�terek sz�ma k�l�nb�z� Twitch t�mogat�si form�k �s manu�lis m�dos�t�sok alapj�n.

## F� funkci�k

- **Kezd� kilom�ter be�ll�t�sa:**  
  Az esem�ny elej�n megadhat� a m�r megtett kilom�terek sz�ma.

- **T�mogat�sok kezel�se:**  
  Az al�bbi t�mogat�si t�pusokhoz automatikusan hozz�adja a megfelel� t�vols�got:
  - **Sub** (Streamloots feliratkoz�s)
  - **Euro** (k�zvetlen p�nzbeli t�mogat�s)
  - **Chest** (Streamloots szerencsel�da)
  - **Bits** (Twitch bits)

- **Egyedi t�vols�g hozz�ad�sa/levon�sa:**  
  Manu�lisan is hozz�adhat� vagy levonhat� m�ter b�rmilyen egy�b t�mogat�s vagy korrekci� eset�n.

- **Dinamikus sz�m�t�s:**  
  Az alkalmaz�s automatikusan kisz�molja, hogy az egyes t�mogat�sok mennyi kilom�tert �rnek, az aktu�lis �sszes�tett kilom�ter alapj�n.  
  
  - 0�5 km:
	- 1 SL sub = 1000 m
	- 1 � = 200 m
	- 1 SL chest = 600 m
	- 100 bit = 200 m
  
  - 5�15 km:
	- 1 SL sub = 600 m
	- 1 � = 125 m
	- 1 SL chest = 400 m
	- 100 bit = 125 m

  - 15�20 km:
	- 1 SL sub = 400 m
	- 1 � = 75 m
	- 1 SL chest = 250 m
	- 100 bit = 75 m

  - 20�25 km:
	- 1 SL sub = 200 m
	- 1 � = 50 m
	- 1 SL chest = 100 m
	- 100 bit = 50 m

  - 25+ km:
	- 1 SL sub = 100 m
	- 1 � = 25 m
	- 1 SL chest = 25 m
	- 100 bit = 25 m

- **Vissza�ll�t�s:**  
  B�rmikor null�zhat� az �sszes kilom�ter, �gy �j esem�ny ind�that�.

- **Felhaszn�l�bar�t fel�let:**  
  Egyszer�, �tl�that�, �l� k�zvet�t�shez optimaliz�lt kezel�fel�let.

## Haszn�lat

1. **�ll�tsd be a kezd� kilom�tert** az esem�ny elej�n.
2. **Add hozz� a t�mogat�sokat** a megfelel� gombokkal, ahogy �rkeznek.
3. **Manu�lisan is m�dos�thatod** a t�vot speci�lis esetekben.
4. **K�vesd az �sszes�tett kilom�tert** val�s id�ben a f� kijelz�n.
5. **Vissza�ll�t�s** eset�n �j s�t�l�s esem�nyt ind�thatsz.

## Licenc

Ez a projekt a [GNU GPL v3](LICENSE.md) alatt �rhet� el.

---

*K�sz�lt a KlikkerTV k�z�ss�gi walkathon streamjeihez a Twitch-en.*
