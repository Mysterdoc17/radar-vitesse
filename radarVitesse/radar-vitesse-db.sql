-- création de la base de données si inexistante
CREATE DATABASE radarVitesse;
USE radarVitesse;

-- création de la table eleves si inexistante
CREATE TABLE IF NOT EXISTS eleves (
    id INT AUTO_INCREMENT,
    nom VARCHAR(255),
    prenom VARCHAR(255),
    PRIMARY KEY (id)
);

-- création de la table vitesse si inexistante
CREATE TABLE IF NOT EXISTS vitesse (
    id INT AUTO_INCREMENT,
    eleve_id INT,
    vitesse FLOAT,
    date DATETIME,
    PRIMARY KEY (id),
    FOREIGN KEY (eleve_id) REFERENCES eleves(id)
);

-- création de la table moyenne si inexistante
CREATE TABLE IF NOT EXISTS moyenne (
    id INT AUTO_INCREMENT,
    eleve_id INT,
    moyenne FLOAT,
    date DATETIME,
    PRIMARY KEY (id),
    FOREIGN KEY (eleve_id) REFERENCES eleves(id)
);

-- création de la table moyenne_classe si inexistante
CREATE TABLE IF NOT EXISTS moyenne_classe (
    id INT AUTO_INCREMENT,
    moyenne FLOAT,
    date DATETIME,
    PRIMARY KEY (id)
);

-- entrée de données de test 
INSERT INTO eleves (nom, prenom) VALUES ('Dupont', 'Jean');
INSERT INTO vitesse (eleve_id, vitesse, date) VALUES (1, 10, '2020-05-01 17:29:45');