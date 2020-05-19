ALTER TABLE ISAD157_LHumphries.friends
ADD INDEX friend_user_id_idx (friend_user_id ASC);
ALTER TABLE ISAD157_LHumphries.friends
ADD CONSTRAINT friend_user_id
FOREIGN KEY (friend_user_id)
REFERENCES ISAD157_LHumphries.details (user_id)
ON DELETE CASCADE
ON UPDATE CASCADE;