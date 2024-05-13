SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';


CREATE SCHEMA IF NOT EXISTS `bp_kviz` DEFAULT CHARACTER SET utf8 COLLATE utf8_unicode_ci ;
USE `bp_kviz` ;

CREATE TABLE IF NOT EXISTS `bp_kviz`.`KVIZ` (
  `RedniBrojPitanja` INT NOT NULL AUTO_INCREMENT,
  `Pitanje` VARCHAR(200) NOT NULL,
  `Odgovor1` VARCHAR(45) NULL,
  `Odgovor2` VARCHAR(45) NULL,
  `Odgovor3` VARCHAR(45) NULL,
  `Odgovor4` VARCHAR(45) NULL,
  `TacanOdgovor` VARCHAR(45) NULL,
  PRIMARY KEY (`RedniBrojPitanja`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koji je klub osvojio finale FA kupa 1986. godine?", "Liverpool", "Everton", "Manchester United", "Brentford", "Liverpool");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koji je nadimak za Manchester United?", "Građani", "Višnjice", "Crveni đavoli", "Švrake", "Crveni đavoli");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Kako je srednje ime ser Aleksa Fergusona?", "Banner", "Clyde", "Champan", "Ewan", "Champan");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Kako se zove zeleni pigment u listu?", "Hloroplast", "Hlorofilin", "Hlorofil", "Karoten", "Hlorofil");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("U kojoj je godini The Godfather prvi put objavljen?", "1971", "1972", "1973", "1974", "1972");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koja je najduza rijeka na svijetu?", "Dunav", "Nil", "Amazon", "Jangcekjang", "Amazon");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koliko je suncokreta bilo u Van Goghovoj trećoj verziji slike 'Suncokreti'?", "11", "12", "13", "14", "12");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koliko udisaja dnevno uzima ljudsko tijelo?", "15 000", "20 000", "25 000", "30 000", "20 000");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Ko pjeva pjesmu 'Nazdravite drugovi'?", "Meho Puzić", "Safet Isović", "Hasim Kučuk", "Angel Dimov", "Hasim Kučuk");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koliko srca ima hobotnica?", "jedno", "dva", "tri", "četiri", "tri");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koje godine je Titanik potonuo u Atlantskom okeanu 15. aprila, djevičanskim putovanjem iz Sautemptona?", "1911", "1912", "1913", "1914", "1912");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koji je glavni grad Portugalije?", "Braga", "Porto", "Lisabon", "Faro", "Lisabon");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("U kojoj zemlji se nalazi Kip slobode?", "Meksiko", "SAD", "Kanada", "Francuska", "SAD");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koji je hemijski simbol za srebro?", "Au", "Ag", "Hg", "Zn", "Ag");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koja je najviša planina u Srbiji?", "Prokletije", "Šar-planina", "Bogićevica", "Koprivnik", "Šar-planina");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koja je najmanja država na svijetu?", "Monako", "Vatikan", "San Marino", "Lihtenštajn", "Vatikan");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koja je najbogatija zemlja na svijetu?", "UAE", "Luksemburg", "Katar", "Makao", "Katar");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Gdje je održano Evropsko prvenstvo u fudbalu 2004. godine?", "Grčka", "Španija", "Portugal", "Francuska", "Portugal");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Ko je napisao knjigu 'Osma ofanziva'?", "Dušan Radović", "Branko Ćopić", "Meša Selimović", "Ivo Andrić", "Branko Ćopić");
insert into KVIZ(Pitanje, Odgovor1, Odgovor2, Odgovor3, Odgovor4, TacanOdgovor) values("Koja je najduža rijeka Evrope?", "Dunav", "Volga", "Ural", "Dnjepar", "Volga");