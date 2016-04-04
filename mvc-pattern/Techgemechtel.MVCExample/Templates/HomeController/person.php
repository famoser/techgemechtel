<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:54
 */
use Techgemechtel\MVCExample\Helpers\FormatHelper;
use Techgemechtel\MVCExample\Views\HomeController\HomeView;

if ($this instanceof HomeView) {
	$person = $this->getPerson();
	echo "Name: " . $person->getName() . "<br/>";
	echo "Age: " . $person->getAge() . "<br/>";
	echo "Birth Date: " . FormatHelper::displayDate($person->getBirthDate());
}
