CREATE TABLE ISAD157_LHumphries.education (
education_Table_ID INT NOT NULL auto_increment,
user_id INT NOT NULL,
school_or_university VARCHAR(100) NOT NULL,
school_uni_start_date VARCHAR(40) NOT NULL,
school_uni_end_date VARCHAR(40) NOT NULL,
PRIMARY KEY (education_Table_ID));