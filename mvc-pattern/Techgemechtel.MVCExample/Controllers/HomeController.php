<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:23
 */

namespace Techgemechtel\MVCExample\Controllers;


use Techgemechtel\MVCExample\Models\PersonModel;
use Techgemechtel\MVCExample\Views\HomeController\HomeView;

class HomeController {
	private $params;
	
	/**
	 * HomeController constructor.
	 *
	 * @param $params : the request URL
	 */
	public function __construct($params) {
		$this->params = $params;
	}
	
	/**
	 * execute the application
	 *
	 * @return string
	 */
	public function execute() {
		if ($this->params == "/") {
			$view = new HomeView("hallo welt!");
			return $view->renderHome();
		}
		else {
			if ($this->params == "/famoser") {
				$view = new HomeView();
				$person = new PersonModel("famoser", "01.01.1990");
				return $view->renderPerson($person);
			}
			else {
				if ($this->params == "/famoser/multiple") {
					$view = new HomeView();
					$persons = array();
					for ($i = 0; $i < 5; $i++)
						$persons[] = new PersonModel("famoser (" . $i . ")", "01.01.1990");
					return $view->renderMultiplePersons($persons);
				}
				else {
					$view = new HomeView("not found");
					$view->addKeyValue("url", $this->params);
					return $view->renderError();
				}
			}
		}
	}
}