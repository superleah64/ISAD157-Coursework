ALTER TABLE ISAD157_LHumphries.messages
ADD INDEX sender_id_idx (sender_id ASC);
ALTER TABLE ISAD157_LHumphries.messages
ADD CONSTRAINT sender_id
FOREIGN KEY (sender_id)
REFERENCES ISAD157_LHumphries.details (user_id)
ON DELETE CASCADE
ON UPDATE CASCADE;