![Docker](https://img.shields.io/badge/docker-%230db7ed.svg?style=for-the-badge&logo=docker&logoColor=white)
# 🐙 Docker - matvelickov-myParfums-asp

Ce projet est une application ASP.NET Core 6.0 déployée avec Docker. Il utilise MySQL comme base de données et PhpMyAdmin pour la gestion de la base de données. L'objectif de ce projet est de démontrer comment configurer et exécuter une application ASP.NET Core avec une base de données MySQL dans un environnement Docker.

## Prérequis

- Docker
- Docker Compose

## Installation

1. Clonez le dépôt GitHub :

    ```bash
    git clone https://github.com/votre-utilisateur/matvelickov-myParfums-asp.git
    cd matvelickov-myParfums-asp
    ```

2. Assurez-vous que Docker et Docker Compose sont installés sur votre machine. Si ce n'est pas le cas, exécutez le script suivant pour les installer ainsi que le runtime ASP.NET Core 6.0 et le SDK .NET Core 6.0 :

    ```bash
    #!/bin/bash

    # Installation de Docker
    curl -fsSL https://get.docker.com -o get-docker.sh
    sudo sh get-docker.sh

    # Installation de Docker Compose
    sudo curl -L "https://github.com/docker/compose/releases/download/1.29.2/docker-compose-$(uname -s)-$(uname -m)" -o /usr/local/bin/docker-compose
    sudo chmod +x /usr/local/bin/docker-compose

    # Passer en mode administrateur
    sudo -i

    # Mise à jour des paquets
    apt update

    # Installation de wget afin de télécharger des fichiers depuis le web
    apt install -y wget apt-transport-https software-properties-common

    # Téléchargement du ficher de configuration pour les packages Microsoft
    wget https://packages.microsoft.com/config/debian/11/packages-microsoft-prod.deb -O packages-microsoft-prod.deb 

    # Installation du fichier de configuration des packages Microsoft
    dpkg -i packages-microsoft-prod.deb

    # Mise à jour des paquets
    apt update

    # Installation du runtime ASP.NET Core 6.0
    apt install -y aspnetcore-runtime-6.0

    # Installation du SDK .NET Core 6.0
    apt install -y dotnet-sdk-6.0
    ```

3. Lancez Docker Compose pour construire et exécuter les conteneurs :

    ```bash
    docker-compose up --build
    ```

## Configuration des Services

- **MySQL** : La base de données MySQL est configurée avec les paramètres suivants :
  - Nom de la base de données : `db_parfums`
  - Utilisateur : `user`
  - Mot de passe utilisateur : `root`
  - Mot de passe root : `root`
  
  La base de données sera initialisée avec le fichier `db_parfums.sql`.

- **PhpMyAdmin** : Accessible via le port `8080` pour la gestion de la base de données.

## Fichiers Importants

- `Dockerfile` : Contient les instructions pour construire l'image Docker pour l'application ASP.NET Core.
- `docker-compose.yml` : Décrit les services Docker (application ASP.NET Core, MySQL, PhpMyAdmin) et leur configuration.
- `db_parfums.sql` : Script SQL utilisé pour initialiser la base de données MySQL.

## Utilisation

1. Accédez à l'application via [http://localhost:80](http://localhost:80).
2. Accédez à PhpMyAdmin via [http://localhost:8080](http://localhost:8080) et connectez-vous avec les informations d'identification MySQL.

## Licence

Ce projet est sous licence MIT. Voir le fichier [LICENSE](LICENSE) pour plus de détails.

