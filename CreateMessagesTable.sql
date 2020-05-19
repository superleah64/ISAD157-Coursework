CREATE TABLE ISAD157_LHumphries.messages (
messages_Table_ID INT NOT NULL auto_increment,
sender_id INT NOT NULL,
receiver_id INT NOT NULL,
date_and_time VARCHAR (40) NOT NULL,
text_contents VARCHAR (500),
PRIMARY KEY (messages_Table_ID));