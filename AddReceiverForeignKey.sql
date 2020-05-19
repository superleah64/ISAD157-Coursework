ALTER TABLE ISAD157_LHumphries.messages
ADD INDEX receiver_id_idx (receiver_id ASC);
ALTER TABLE ISAD157_LHumphries.messages
ADD CONSTRAINT receiver_id
FOREIGN KEY (receiver_id)
REFERENCES ISAD157_LHumphries.details (user_id)
ON DELETE CASCADE
ON UPDATE CASCADE;