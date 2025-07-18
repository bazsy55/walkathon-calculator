# Walkathon Calculator

Ez az alkalmazás a [KlikkerTV](https://www.twitch.tv/klikkertv) walkathon stream eseményéhez készült.  
Segítségével valós idõben követhetõ és számolható az összegyûlt kilométerek száma különbözõ Twitch támogatási formák és manuális módosítások alapján.

## Fõ funkciók

- **Kezdõ kilométer beállítása:**  
  Az esemény elején megadható a már megtett kilométerek száma.

- **Támogatások kezelése:**  
  Az alábbi támogatási típusokhoz automatikusan hozzáadja a megfelelõ távolságot:
  - **Sub** (Streamloots feliratkozás)
  - **Euro** (közvetlen pénzbeli támogatás)
  - **Chest** (Streamloots szerencseláda)
  - **Bits** (Twitch bits)

- **Egyedi távolság hozzáadása/levonása:**  
  Manuálisan is hozzáadható vagy levonható méter bármilyen egyéb támogatás vagy korrekció esetén.

- **Dinamikus számítás:**  
  Az alkalmazás automatikusan kiszámolja, hogy az egyes támogatások mennyi kilométert érnek, az aktuális összesített kilométer alapján.  
  
  - 0–5 km:
	- 1 SL sub = 1000 m
	- 1 € = 200 m
	- 1 SL chest = 600 m
	- 100 bit = 200 m
  
  - 5–15 km:
	- 1 SL sub = 600 m
	- 1 € = 125 m
	- 1 SL chest = 400 m
	- 100 bit = 125 m

  - 15–20 km:
	- 1 SL sub = 400 m
	- 1 € = 75 m
	- 1 SL chest = 250 m
	- 100 bit = 75 m

  - 20–25 km:
	- 1 SL sub = 200 m
	- 1 € = 50 m
	- 1 SL chest = 100 m
	- 100 bit = 50 m

  - 25+ km:
	- 1 SL sub = 100 m
	- 1 € = 25 m
	- 1 SL chest = 25 m
	- 100 bit = 25 m

- **Visszaállítás:**  
  Bármikor nullázható az összes kilométer, így új esemény indítható.

- **Felhasználóbarát felület:**  
  Egyszerû, átlátható, élõ közvetítéshez optimalizált kezelõfelület.

## Használat

1. **Állítsd be a kezdõ kilométert** az esemény elején.
2. **Add hozzá a támogatásokat** a megfelelõ gombokkal, ahogy érkeznek.
3. **Manuálisan is módosíthatod** a távot speciális esetekben.
4. **Kövesd az összesített kilométert** valós idõben a fõ kijelzõn.
5. **Visszaállítás** esetén új sétálós eseményt indíthatsz.

## Licenc

Ez a projekt a [GNU GPL v3](LICENSE.md) alatt érhetõ el.

---

*Készült a KlikkerTV közösségi walkathon streamjeihez a Twitch-en.*
