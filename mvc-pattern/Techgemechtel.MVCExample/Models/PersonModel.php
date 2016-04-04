<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:53
 */

namespace Techgemechtel\MVCExample\Models;


class PersonModel {
	private $name;
	private $age;
	private $birthDate;

	public function __construct($name, $birthDate) {
		$this->name = $name;
		$this->birthDate = $birthDate;
	}

	/**
	 * @return string
	 */
	public function getName() {
		return $this->name;
	}

	/**
	 * @return int
	 */
	public function getAge() {
		return date("Y", time() - strtotime($this->getBirthDate()));
	}

	/**
	 * @return string
	 */
	public function getBirthDate() {
		return $this->birthDate;
	}
}