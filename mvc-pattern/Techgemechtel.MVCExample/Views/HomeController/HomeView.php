<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:19
 */

namespace Techgemechtel\MVCExample\Views\HomeController;


use Techgemechtel\MVCExample\Models\PersonModel;

class HomeView {
	private $message;
	private $person;
	private $keyValues;
	
	/**
	 * HomeView constructor.
	 *
	 * @param string $message : the message displayed in the view
	 */
	public function __construct($message = null) {
		$this->message = $message;
	}
	
	/**
	 * @return string
	 */
	public function getMessage() {
		return $this->message;
	}
	
	/**
	 * @return PersonModel
	 */
	public function getPerson() {
		return $this->person;
	}
	
	/**
	 * @param string $key
	 * @param string $value
	 * use this function to pass simple data to the view
	 */
	public function addKeyValue($key, $value) {
		$this->keyValues[$key] = $value;
	}
	
	/**
	 * @param string $key
	 * retrieves values added by addKeyValue from the controller
	 *
	 * @return mixed
	 */
	public function getValue($key) {
		return $this->keyValues[$key];
	}
	
	/**
	 * @return string
	 * render the error template
	 */
	public function renderError() {
		return $this->includeFile("error");
	}
	
	/**
	 * @return string
	 * render the home template
	 */
	public function renderHome() {
		return $this->includeFile("index");
	}
	
	/**
	 * @param PersonModel $person
	 * render the person template
	 *
	 * @return string
	 */
	public function renderPerson(PersonModel $person) {
		$this->person = $person;
		return $this->includeFile("person");
	}

	/**
	 * @param PersonModel[] $persons
	 * render multiple persons
	 *
	 * @return string
	 */
	public function renderMultiplePersons(array $persons) {
		$result = "";
		foreach ($persons as $person) {
			$this->person = $person;
			$result .= "<p>" . $this->includeFile("person") . "</p>";
		}
		return $result;
	}

	
	/**
	 * @param string $fileName
	 * renders a file, writes the output it produces into a variable and returns that.
	 *
	 * @return string
	 */
	private function includeFile($fileName) {
		ob_start();
		include $_SERVER["DOCUMENT_ROOT"] . DIRECTORY_SEPARATOR . "Templates" . DIRECTORY_SEPARATOR . "HomeController" . DIRECTORY_SEPARATOR . $fileName . ".php";
		$res = ob_get_contents();
		ob_end_clean();
		return $res;
	}
}