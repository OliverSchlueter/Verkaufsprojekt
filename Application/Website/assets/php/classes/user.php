<?php

class User{
    var $id;
    var $firstName;
    var $lastName;
    var $nickName;
    var $email;
    var $birthday;
    var $creationDate;
    var $password;

    public function __construct($id, $firstName, $lastName, $nickName, $email, $birthday, $creationDate, $password){
        $this->id = $id;
        $this->firstName = $firstName;
        $this->lastName = $lastName;
        $this->nickName = $nickName;
        $this->email = $email;
        $this->birthday = $birthday;
        $this->creationDate = $creationDate;
        $this->password = $password;
    }

}

class Customer extends User{
    var $balance;

    function __construct($id, $firstName, $lastName, $nickName, $email, $birthday, $creationDate, $password, $balance) {
        parent::__construct($id, $firstName, $lastName, $nickName, $email, $birthday, $creationDate, $password);
        $this->balance = $balance;
    }
}

class Autor extends User{
    var $devStatus;

    function __construct($id, $firstName, $lastName, $nickName, $email, $birthday, $creationDate, $password, $devStatus) {
        parent::__construct($id, $firstName, $lastName, $nickName, $email, $birthday, $creationDate, $password);
        $this->devStatus = $devStatus;
    }
}

function getNewUserID($db){
    $currentIDs = [];

    foreach($db->query("SELECT benutzerID FROM benutzer") as $row){
        $currentIDs[count($currentIDs)] = $row['benutzerID'];
    }

    $validCharsS = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ01234567890123456789";
    $validChars = str_split($validCharsS);

    while (true) {
        $id = "";
        for ($i=0; $i <5; $i++) { 
            $id .= $validChars[random_int(0,count($validChars))];
        }

        if(!in_array($id, $currentIDs)){
            return $id;
        }
    }


}

?>