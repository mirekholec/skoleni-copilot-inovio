---
applyTo: "**/*.html, **/*.razor, **/*.cshtml"
---
# Standardy pro HTML

Cílem je udržet vysokou kvalitu HTML kódu, zlepšovat sémantiku, přístupnost a čitelnost šablon.

## Obecné zásady

- Používej sémantické HTML elementy (`<header>`, `<main>`, `<footer>`, `<nav>`, `<section>`, `<article>`, `<aside>`) místo „div soup“.
- Každá stránka by měla mít jeden hlavní obsah v elementu `<main>`.
- Dbej na validní a dobře zanořený HTML (žádné neuzavřené tagy, překřížené elementy, duplicitní `id`).
- Nevkládej zbytečné obalové elementy – HTML by mělo být co nejjednodušší a přehledné.

## Nadpisy a struktura obsahu

- Používej přesně jeden `<h1>` na stránku/šablonu (hlavní nadpis).
- Nadpisy řaď hierarchicky (`<h1>` → `<h2>` → `<h3>` …), nad úrovně nepřeskakuj jen kvůli velikosti písma.
- Nadpisy používej pro logickou strukturu obsahu, ne pro vizuální formátování.

## Přístupnost (a11y)

- Každý `<img>` musí mít smysluplný atribut `alt`. Pokud je čistě dekorativní, použij `alt=""`.
- Interaktivní prvky používej s odpovídajícími tagy:
  - akce → `<button>` (nikoliv `<div>` nebo `<span>` s `onclick`)
  - odkazy → `<a href="…">`
- Formulářové prvky (`<input>`, `<select>`, `<textarea>`) musí mít asociovaný `<label>` (přes `for`/`id` nebo obalení) a podle typu přidej i vhodný `autocomplete` atribut.
- U ikonových tlačítek nebo odkazů (např. jen ikonka bez textu) zajisti text pro čtečky obrazovky (`aria-label` nebo skrytý text).

## Vazba na CSS a JavaScript

- Nepoužívej inline styly (`style="…"`) – styly patří do CSS.
- Nepoužívej inline JavaScript (`onclick="…"`, `onchange="…"`) – logika patří do skriptů, ne do značek.
- Preferuj smysluplné názvy tříd, které popisují roli/komponentu, ne konkrétní vizuální vlastnost (např. `.btn-primary` místo `.blue-text-18px`).

## Specifika Razor / CSHTML

- V Razor šablonách udržuj logiku minimální – šablona by měla primárně obsahovat HTML a jednoduché podmínky/cykly.
- Složitější logiku řeš raději v rámci code behind než přímo v šabloně.