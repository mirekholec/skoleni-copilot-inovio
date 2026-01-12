# Napiš README.md pro projekt

Jsi zkušený vývojář a technický writer. Z vybraného souboru / adresáře / celé codebase vygeneruj stručný návrh `README.md` v čistém Markdownu.

## Jak postupovat

- Z kódu odvoď:
  - typ projektu (knihovna, CLI nástroj, webová app, služba, monorepo…),
  - hlavní účel (co dělá, pro koho je),
  - hlavní technologie a závislosti.
- Nepiš nic, co nelze rozumně vyčíst z kódu nebo konfigurace.
- README drž krátké a věcné – max. několik odstavců a seznamů.

## Struktura README

Vytvoř README s tímto minimálním skeletonem (sekce, které nedávají smysl, vynech):

1. **Název a jednovětý popis**
2. **Přehled / Overview**  
   - 2–3 věty: jaký problém řeší, hlavní scénáře použití.
3. **Klíčové vlastnosti**  
   - krátký seznam hlavních funkcí.
4. **Technologie / Dependencies**  
   - rámcový seznam hlavních technologií, frameworků, knihoven.
5. **Instalace a spuštění (Setup & Run)**  
   - pár kroků, jak projekt zprovoznit (klonování, instalace závislostí, příkaz ke spuštění).
6. **Konfigurace (Configuration)**  
   - kde se nastavuje konfigurace (konfigurační soubory, proměnné prostředí apod.).
7. **Testy (Tests)**  
   - jak spustit testy, pokud existují.
8. **Licence (License)**  
   - vycházej z existujících souborů v repo (např. `LICENSE`). Pokud nic nenajdeš, sekci vynech.

## Zásady

- Buď konkrétní, ale stručný – žádné marketingové fráze ani dlouhé eseje.
- Nepoužívej placeholdery typu „TODO“, pokud danou informaci lze zjistit.
- Používej jazyk, který převažuje v kódu a komentářích (česky nebo anglicky).