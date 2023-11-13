CREATE TABLE szakterulet(
   szakterulet_id INTEGER  NOT NULL PRIMARY KEY 
  ,megnevezes     VARCHAR(40) NOT NULL
);
INSERT INTO szakterulet(szakterulet_id,megnevezes) VALUES (1,'állampapír');
INSERT INTO szakterulet(szakterulet_id,megnevezes) VALUES (2,'kötvény');
INSERT INTO szakterulet(szakterulet_id,megnevezes) VALUES (3,'részvény');
INSERT INTO szakterulet(szakterulet_id,megnevezes) VALUES (4,'ingatlan');
INSERT INTO szakterulet(szakterulet_id,megnevezes) VALUES (5,'forex');
