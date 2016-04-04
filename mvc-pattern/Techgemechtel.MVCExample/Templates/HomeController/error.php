<?php
/**
 * Created by PhpStorm.
 * User: famoser
 * Date: 04/04/2016
 * Time: 21:25
 */
use Techgemechtel\MVCExample\Views\HomeController\HomeView;

if ($this instanceof HomeView) { ?>
	<h1>Error occurred at <?= $this->getValue("url") ?></h1>

	<?php
	echo $this->getMessage();
}