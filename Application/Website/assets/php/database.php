<?php
    $db = @new mysqli('localhost', 'root', '', 'verkaufsprojekt');
    $connectedToDatabase = false;
    if($db->connect_error) {
        $connectedToDatabase = false;
    } else {
        $connectedToDatabase = true;
    }
?>