#!/bin/bash

# Skript pro vytvoření nového GitHub repository pro firmu
set -e

# Zeptej se na název firmy
read -p "Zadej název firmy: " COMPANY_NAME

# Ověř, že byl zadán název
if [ -z "$COMPANY_NAME" ]; then
    echo "Chyba: Název firmy nebyl zadán!"
    exit 1
fi

# Převeď název na malá písmena a nahraď mezery pomlčkami
COMPANY_NAME=$(echo "$COMPANY_NAME" | tr '[:upper:]' '[:lower:]' | tr ' ' '-')
REPO_NAME="skoleni-copilot-${COMPANY_NAME}"

echo "Vytváření repository: $REPO_NAME"

# Smaž .git složku
if [ -d ".git" ]; then
    echo "Mažu existující .git složku..."
    rm -rf .git
fi

# Inicializuj nový git repository
echo "Inicializuji nový git repository..."
git init

# Přidej všechny soubory
git add .

# Vytvoř první commit
git commit -m "Initial commit for $COMPANY_NAME training"

# Vytvoř nové GitHub repository (veřejné)
echo "Vytvářím GitHub repository..."
gh repo create "$REPO_NAME" --public --source=. --push

echo "Hotovo! Repository $REPO_NAME bylo vytvořeno a obsah nahrán."
echo "URL: https://github.com/$(gh api user --jq .login)/$REPO_NAME"
