USE master
  GO
    IF EXISTS (SELECT 'True' FROM sys.databases WHERE NAME = 'management_system')
      BEGIN
        ALTER DATABASE management_system SET SINGLE_USER WITH ROLLBACK IMMEDIATE
        DROP DATABASE management_system
      END
  GO
    CREATE DATABASE management_system
  GO
    ALTER AUTHORIZATION ON DATABASE::management_system TO sa
    USE management_system 
  GO
		 CREATE TYPE names FROM NVARCHAR(256);
	GO


	--AUTENTIFICARE
	BEGIN
		 CREATE TABLE users
    (
     id_users INT PRIMARY KEY IDENTITY(100,1),
     username names UNIQUE,
		 password names NOT NULL,
		 secret_word names NOT NULL
    );
	
		INSERT INTO users(username, password, secret_word)
		VALUES ('admin', 'vBRIgwDgq1tIYUidtyI+oQ==', 'administrator') --pass = admin

	END

  --CREAREA TABELELOR

  BEGIN
		CREATE TABLE peoples
		(
			id_peoples INT PRIMARY KEY IDENTITY(100,1),
			full_name names NOT NULL,
			date_of_birth DATE NOT NULL,
			idnp names UNIQUE
		);

		CREATE TABLE peoples_pension
		(
			id_pensionar INT PRIMARY KEY IDENTITY(100,1),
			id_peoples INT UNIQUE,
			pensie_numerar FLOAT NOT NULL,
			FOREIGN KEY (id_peoples) REFERENCES peoples(id_peoples)
		);

		CREATE TABLE peoples_deces
		(
			id_deces INT PRIMARY KEY IDENTITY(100,1),
			full_name names NOT NULL,
			date_of_birth DATE NOT NULL,
			idnp names UNIQUE,
			date_of_death DATE NOT NULL
		);

		CREATE TABLE peoples_bolnav
		(
			id_bolnav INT PRIMARY KEY IDENTITY(100,1),
			id_peoples INT UNIQUE,
			tip_evidenta names NOT NULL,
			diagnoza names NOT NULL,
			FOREIGN KEY (id_peoples) REFERENCES peoples(id_peoples)
		);

		CREATE TABLE cote
		(
			id_cote INT PRIMARY KEY IDENTITY(100,1),
			id_peoples INT NOT NULL,
			nr_cadastral INT DEFAULT '7185',
			nr_pamant INT UNIQUE,
			suprafata_h FLOAT NOT NULL,
			FOREIGN KEY (id_peoples) REFERENCES peoples(id_peoples)
		);

		CREATE TABLE cote_semanat
		(
			id_semanat INT PRIMARY KEY IDENTITY(100,1),
			id_cote INT NOT NULL,
			an_semanat INT NOT NULL,
			tip_planta names NOT NULL
			FOREIGN KEY (id_cote) REFERENCES cote(id_cote)
		);

		CREATE TABLE cote_recolta
		(
			id_recolta INT PRIMARY KEY IDENTITY(100,1),
			id_semanat INT NOT NULL,
			tone_recolta FLOAT NOT NULL
			FOREIGN KEY (id_semanat) REFERENCES cote_semanat(id_semanat)
		);

		CREATE TABLE cote_zahar
		(
			id_cote_zahar INT PRIMARY KEY IDENTITY(100,1),
			id_semanat INT NOT NULL,
			zahar_kg INT NOT NULL
			FOREIGN KEY (id_semanat) REFERENCES cote_semanat(id_semanat)
		);
	END
