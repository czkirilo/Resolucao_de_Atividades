package testesenaicursos;

import java.util.concurrent.TimeUnit;

import org.junit.Before;
import org.junit.Test;
import org.openqa.selenium.By;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class TesteBuscarCursos {
private WebDriver driver;

@Before
public void abrirNavegador() {
	System.setProperty("webdriver.chrome.driver", "C:\\Program Files\\chromedriver\\chromedriver.exe");
	driver = new ChromeDriver();
	driver.manage().window().maximize();
}

@Test
public void testeNavegador() {
	driver.get("https://informatica.sp.senai.br/");
	driver.manage().timeouts().implicitlyWait(3, TimeUnit.SECONDS);
	driver.findElement(By.id("Busca1_txtFiltro")).sendKeys("robótica");
	
	
	driver.findElement(By.id("Busca1_btnBusca")).click();
	
	String[]listaCurso= {"Gestão","Administração", "TI", "Robotica"};
	for(int tentativas = 0; tentativas < listaCurso.length; tentativas++) {
		try {
			inputCurso.clear();
			
			inputCurso.sendKeys(listaCurso[tentativas]);
			botaoCurso.click();
			
		}catch(InterruptedException e) {
			e.printStackTrace();
		}
	}
	

}
