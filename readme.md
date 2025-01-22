# Projet 4 - Système Bancaire (Maze Bank)

Ce projet implémente un système bancaire simple permettant à un utilisateur de s'identifier et d'effectuer diverses opérations financières sur son compte.

## Fonctionnalités

Le programme permet à l'utilisateur d'effectuer les actions suivantes :

1. **Connexion** : L'utilisateur doit entrer un mot de passe pour accéder à son compte. Si le mot de passe est correct, le menu principal est affiché.
2. **Retirer de l'argent** : L'utilisateur peut retirer une certaine somme d'argent de son solde bancaire.
3. **Ajouter de l'argent** : L'utilisateur peut ajouter de l'argent à son compte bancaire.
4. **Vérifier le solde** : L'utilisateur peut consulter le solde actuel de son compte.
5. **Quitter** : L'utilisateur peut quitter l'application à tout moment.

## Structure du Code

### `Program.cs`

Le fichier principal du projet qui contient la logique pour :

- **Vérification de l'identification** : Le programme charge une liste de comptes et vérifie si le mot de passe entré correspond à l'un d'eux.
- **Menu principal** : Une fois connecté, un menu d'options est présenté à l'utilisateur.
- **Opérations bancaires** : Les méthodes permettant de retirer de l'argent, d'ajouter de l'argent ou de vérifier le solde du compte.

### `Account.cs`

La classe `Account` représente un compte bancaire avec les propriétés suivantes :
- `Name` : Le nom du titulaire du compte.
- `Password` : Le mot de passe du titulaire du compte.
- `Balance` : Le solde actuel du compte bancaire.

### Liste des comptes initiale

Une liste de comptes est créée au début, avec des exemples d'utilisateurs pré-définis :

- **Jose** : Mot de passe = `1234`, Solde = `1000`
- **Keito** : Mot de passe = `gerber`, Solde = `10`
- **Gabriel** : Mot de passe = `swispace`, Solde = `2000`

### Méthodes

1. **Login()** : Demande à l'utilisateur de se connecter avec son mot de passe.
2. **Menu()** : Affiche le menu avec des options permettant de gérer les opérations bancaires.
3. **Withdraw()** : Permet à l'utilisateur de retirer une certaine somme d'argent de son compte, à condition d'avoir un solde suffisant.
4. **AddMoneyToAccount()** : Permet à l'utilisateur d'ajouter de l'argent à son compte.
5. **VerifyMoneyAccount()** : Permet à l'utilisateur de vérifier le solde actuel de son compte.

## Comment Utiliser

1. Lancer l'application.
2. S'identifier en entrant un mot de passe valide d'un des comptes.
3. Sélectionner l'une des options dans le menu principal pour effectuer une opération (retirer, ajouter de l'argent, vérifier le solde ou quitter).
4. Le programme continue à afficher le menu après chaque opération, jusqu'à ce que l'utilisateur choisisse de quitter.

## Exemple de Fonctionnement

```plaintext
Bienvenue dans la Maze Bank!
Veuillez vous vous identifier
Mot de passe : gerber

Bienvenue Keito que voulez vous faire?
1.Retirer de l'argent
2.Ajouter de l'argent
3.Voir solde bancaire
4.Quitter

Veuillez entrer un choix : 3
Voici votre solde: 10
