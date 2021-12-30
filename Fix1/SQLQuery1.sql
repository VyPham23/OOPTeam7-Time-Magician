CREATE TABLE USERS(
  "Id" integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  "Name" text NOT NULL,
  "Password" text NOT NULL);

CREATE TABLE "Priorities" (
  "Id" integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  "Name" text NOT NULL);

CREATE TABLE "Tasks" (
  "Id" integer NOT NULL PRIMARY KEY AUTOINCREMENT,
  "Done" integer NOT NULL DEFAULT 0,
  "DueDate" DATETIME,
  "Priority" integer NOT NULL DEFAULT 0,
  "Task" text,
  "Details" text,
  "User" integer NOT NULL);

INSERT INTO "USERS" VALUES (1, 'Alex', '111');
INSERT INTO "Users" VALUES (2, 'Daniel', '222');

INSERT INTO "Priorities" VALUES (1, 'Low');
INSERT INTO "Priorities" VALUES (2, 'Normal');
INSERT INTO "Priorities" VALUES (3, 'High');

INSERT INTO "Tasks" VALUES (1, 0, '2014-08-01 00:00:00.0000', 1,
  'Learn DA', 'Learn Data Abstract', 2);