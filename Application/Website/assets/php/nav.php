<?php

class NavigationBar{
    var $pages;

    public function __construct($pages) {
        $this->pages = $pages;
    }

    public function getNav($onMainPage, $activePage){
        session_start();
        
        echo "<ul>";

        foreach ($this->pages as $page) {
            $page->active = false;
            if($page->pageName == $activePage){
                $page->active = true;
            }
            $page->getListItem($onMainPage);
        }

        echo "</ul>";
    }

}

class NavigationPage{
    var $pageName;
    var $displayName;
    var $active;
    var $right;
    var $requireLogin;
    var $showWhenLoggedIn;

    public function __construct($pageName, $displayName, $active, $right, $requireLogin, $showWhenLoggedIn) {
        $this->pageName = $pageName;
        $this->displayName = $displayName;
        $this->active = $active;
        $this->right = $right;
        $this->requireLogin = $requireLogin;
        $this->showWhenLoggedIn = $showWhenLoggedIn;
    }

    public function getListItem($fromMainPage) {   
        
        $loggedIn = false;

        if(isset($_SESSION['user'])){
            $loggedIn = true;
        }

        if($loggedIn && !$this->showWhenLoggedIn){
            return;
        }

        if(!$loggedIn && $this->requireLogin){
            return;
        }

        $listItemString = "<li %right%><a %active% href='%fromMainPage%".$this->pageName."/'>".$this->displayName."</a></li>";
        
        $listItemString = str_replace("%right%", $this->right == true ? "class='right'" : "", $listItemString);
        $listItemString = str_replace("%active%", $this->active == true ? "class='active'" : "", $listItemString);
        $listItemString = str_replace("%fromMainPage%", $fromMainPage == false ? "../" : "", $listItemString);
        
        echo $listItemString;
    }
}

$nav = new NavigationBar(
    [
        new NavigationPage("#", "Startseite", true, false, false, true),
        new NavigationPage("products", "Produkte", false, false, false, true),
        new NavigationPage("register", "Registieren", false, true, false, false),
        new NavigationPage("login", "Einloggen", false, true, false, false),
        new NavigationPage("profile", "Profil", false, true, true, true)
    ]
);


?>