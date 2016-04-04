<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:17
 */
use Techgemechtel\MVCExample\Views\HomeController\HomeView;

if ($this instanceof HomeView) {
	echo $this->getMessage();
}