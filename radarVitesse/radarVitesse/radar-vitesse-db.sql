-- création de la base de données si inexistante
CREATE DATABASE IF NOT EXISTS radar-vitesse;
USE radar-vitesse;

-- création de la table eleves si inexistante
CREATE TABLE IF NOT EXISTS radar-vitesse.eleves (
    id INT AUTO_INCREMENT,
    nom VARCHAR(255),
    prenom VARCHAR(255),
    PRIMARY KEY (id)
);

-- création de la table vitesse si inexistante
CREATE TABLE IF NOT EXISTS radar-vitesse.vitesse (
    id INT AUTO_INCREMENT,
    eleve_id INT,
    vitesse FLOAT,
    date DATETIME,
    PRIMARY KEY (id),
    FOREIGN KEY (eleve_id) REFERENCES radar-vitesse.eleves(id)
);

-- création de la table moyenne si inexistante
CREATE TABLE IF NOT EXISTS radar-vitesse.moyenne (
    id INT AUTO_INCREMENT,
    eleve_id INT,
    moyenne FLOAT,
    date DATETIME,
    PRIMARY KEY (id),
    FOREIGN KEY (eleve_id) REFERENCES radar-vitesse.eleves(id)
);

-- création de la table moyenne_classe si inexistante
CREATE TABLE IF NOT EXISTS radar-vitesse.moyenne_classe (
    id INT AUTO_INCREMENT,
    moyenne FLOAT,
    date DATETIME,
    PRIMARY KEY (id)
);

-- entrée de données
INSERT INTO radar-vitesse.eleves (nom, prenom) VALUES ('Dupont', 'Jean');
INSERT INTO radar-vitesse.vitesse (eleve_id, vitesse, date) VALUES (1, 10, '2020-05-01 17:29:45');