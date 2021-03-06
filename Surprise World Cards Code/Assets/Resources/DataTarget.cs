 using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class DataTarget : MonoBehaviour
    {

        public Transform TextTargetName;
        public Transform TextDescription;
		public Transform ButtonSound;
        public Transform PanelDescription;
		public Transform ButtonSpanish;
		public Transform ButtonEnglish;

        public AudioSource soundTarget;
        public AudioClip clipTarget;


        // Use this for initialization
        void Start()
        {
		//add Audio Source as new game object component
            soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();
        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();

                Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);
			
//Evertime the target found it will show “name of target” on the TextTargetName. Button, Description and Panel will visible (active)

                TextTargetName.GetComponent<Text>().text = name;
                ButtonEnglish.gameObject.SetActive(true);
				ButtonSpanish.gameObject.SetActive(true);
				ButtonSound.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);

				switch (name) {

				case "Aguila":
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/aguilai");
					});
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/aguilae");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/aguila1");
					});
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Águila: Ave rapaz de aproximadamente 2 m de largo, con vista muy aguda, fuerte musculatura, pico curvo y ganchudo, garras afiladas y vuelo rapidísimo. ";	
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Eagle: Bird of prey about 2 m long, with very sharp sight, strong musculature, curved beak and hook, sharp claws and very fast flight. ";
					});
					break;

				case "Araña":
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/arañae");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/arañai");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/araña");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Spider: Arachnid of four pairs of legs presenting a small non-articulated thorax to which a bulging abdomen joins, at the end of which the silk producing organs. ";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Araña: Arácnido de cuatro pares de patas que presenta un pequeño tórax no articulado al que se une un abdomen abultado, en cuyo extremo tiene los órganos productores de seda. ";
					});
					break;

                case "Ardilla":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/ardillae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/ardillai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/ardilla");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Squirrel:Mammal rodent, usually reddish hair on the back and white on the belly, large tail, which is very common in forests and wooded areas ";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Ardilla: Mamífero roedor, de pelo generalmente rojizo por el lomo y blanco por el vientre, cola grande, que es muy común en los bosques y zonas arboladas ";
					});
						break;

				case "Armadillo":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/armadilloe");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/armadilloi");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/Armadillo");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Armadillo: American mammal, with the body covered by a shell formed by overlapping plates, long snout and large ears ";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Armadillo: Mamífero americano, con el cuerpo cubierto por un caparazón formado por placas sobrepuestas, hocico largo y orejas grandes ";
					});
					break;

				case "Avestruz":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/avestruze");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/avestruzi");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/avestruz");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Ostrich: Brood bird, large, long, sturdy legs, naked neck and only two fingers at each end, living in Africa. ";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Avestruz: Ave corredora, de gran tamaño, patas largas y robustas, cuello desnudo y sólo dos dedos en cada extremidad, que vive en África. ";
					});
					break;

				case "Ballena":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/ballenae");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/ballenai");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/ballena1");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Whale: Large marine mammal, dark above and whitish below, which lacks teeth but has a large number of beards fixed to the upper jaw used to filter the food. ";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Ballena: Mamífero marino de gran tamaño, oscuro por encima y blanquecino por debajo, que carece de dientes pero posee un gran número de barbas fijas a la mandíbula superior que utiliza para filtrar el alimento. ";
					});
					break;

				case "Búho":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/buhoe");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/buhoi");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/buho");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Owl: Bird of prey, often nocturnal, with claws hooked and feathered, a large head that can give almost the complete turn, with a short beak, and fixed large eyes. ";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Búho: Ave de rapiña, a menudo nocturna, con garras enganchadas y emplumadas, una cabeza grande que puede dar casi la vuelta completa, con un pico corto, y fijos grandes ojos. ";
					});
					break;

                case "Caballo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cabelloe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/caballoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/caballo1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Horse: A domesticated, long-stranded mammal with herbivorous feeding, the legs are terminated in a single finger, and the neck and tail are populated with long mane. ";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Caballo: Mamífero domesticado, de gran zancada y alimentación herbívora, que tiene las patas terminadas en un único dedo, y el cuello y la cola poblados con crines largas. ";
					});
					break;

                case "CaballodeMar":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/caballodemare");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/caballodemari");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Seahorse: Small marine fish whose name refers to the resemblance of his face to that of the terrestrial horses. His body is covered by a ring armor. ";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Caballo de mar: Pequeño pez marino cuyo  nombre hace referencia al parecido de su rostro con el de los caballos terrestres. Su cuerpo está cubierto por una armadura de anillos. ";
					});
					break;

                case "Cabra":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cabrae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cabrai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/cordero1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Goat: Small mammal with hollow horns arched backwards, a long strand hanging from the lower jaw and very short tail. Adapted to jump and climb. It is created by man to obtain milk, meat, skin and hair.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cabra: Mamífero pequeño de cuernos huecos arqueados hacia atrás, un mechón de pelos largos colgante de la mandíbula inferior y cola muy corta. Adaptada a saltar y escalar. Es criada por el hombre para obtener leche, carne, piel y pelo.";
					});
					break;

                case "Camaleon":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/camaleone");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/camaleoni");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/camaleon");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Chameleon: Scaly reptile about 30 cm in length, eyes with independent movement. It feeds on insects that it hunts with its fast, long and sticky tongue. Your skin changes color to suit the objects around you.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Camaleon: Reptil escamoso de unos 30 cm de longitud, ojos de movimiento independiente. Se alimenta de insectos que caza con su lengua rápida, larga y pegajosa. Su piel cambia de color para adaptarse al de los objetos que le rodean. ";
					});
					break;

                case "Camello":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/camelloe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/camelloi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/camello1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Camel: Mammal from Central Asia, up to 3 m tall, with long neck, proportionally small head and two gibs on the back, formed by accumulation of fatty tissue. It can store water in your body, so it adapts to life in desert areas.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Camello: Mamífero originario de Asia central, de hasta 3 m de altura, que tiene el cuello largo, la cabeza proporcionalmente pequeña y dos gibas en el dorso, formadas por acumulación de tejido graso. Puede almacenar agua en su cuerpo, por lo que se adapta a la vida en zonas desérticas.";
					});
					break;

				case "Cangrejo":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/cangrejoe");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/cangrejoi");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/cangrejo");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Crab: Crustacean of river or sea with the front legs finished in tongs; The one of river has the blackish green shell, and the one of sea has the round body similar to the one of the spider. They are much appreciated as food";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cangrejo: Crustáceo de río o de mar con las patas delanteras acabadas en pinzas; el de río tiene el caparazón negro verdoso, y el de mar tiene el cuerpo redondo parecido al de la araña. Son muy apreciados como alimento";
					});
					break;

				case "Canguro":
                
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/canguroe");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/canguroi");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/canguro");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Kangaroo: An herbivorous mammal from Australia that jumps in, with the front extremities much shorter than the hind legs and with a sturdy tail on which it rests. Females have a bag in their belly to carry their young.";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Canguro :Mamífero herbívoro de Australia que se desplaza a saltos, con las extremidades delanteras mucho más cortas que las posteriores y con una cola robusta en la que se apoya. Las hembras tienen una bolsa en el vientre para llevar a sus crías.";
					});
					break;

                case "Caracol":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/caracole");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/caracoli");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/caracol");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Snail: Terrestrial, marine or freshwater mollusc, with a spiral shell on its back. It produces a drool to help in its slow displacement. Some species are edible.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Caracol: Molusco terrestre, marino o de agua dulce, con una concha en espiral en su lomo. Produce una baba para ayudarse en su lento desplazamiento. Algunas especies son comestibles.";
					});
					break;

                case "Cebra":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cebrae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cebrai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/cebra");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Zebra: African mammal, with yellowish white hair with brown or black cross stripes, which serves to camouflage itself. He has eyes at the sides of the head giving a wide visual angle.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cebra: Mamífero africano, de pelo blanco amarillento con rayas transversales pardas o negras, lo que le sirve para camuflarse. Tiene los ojos a los lados de la cabeza dándole un amplio ángulo visual.";
					});
					break;

                case "Cerdo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cerdoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cerdoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/cerdo2");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Pig: Domestic mammal with large head, thick and rough body, short legs, drooping ears and annoying snout. It is bred to take advantage of its meat and fat.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cerdo: Mamífero doméstico de cabeza grande, cuerpo grueso y áspero, patas cortas, orejas caídas y hocico chato. Se cría para aprovechar su carne y grasa.";
					});
					break;

                case "Chimpance":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/chimpancee");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/chimpancei");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/chimp1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Chimpanzee: African mammal with black or monkey hair, long arms and large head. He is quite intelligent, lives in small groups in trees and on the ground and feeds on leaves, fruits, seeds and small animals.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Chimpancé: Mamífero africano de pelo negro o mono, brazos largos y cabeza grande. Es bastante inteligente, vive en pequeños grupos en árboles o en el suelo y se alimenta de hojas, frutos, semillas y pequeños animales.";
					});
					break;

                case "Cienpies":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cienpiese");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cienpiesi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Centipede: Insect with a pair of legs in each of the 21 rings in which his body is divided. In the head has tongs with which they bite the animals and inject poison.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cienpies: Insecto con un par de patas en cada uno de los 21 anillos en que se divide su cuerpo. En la cabeza tiene unas tenazas con las que muerden a los animales y les inyectan veneno.";
					});
					break;

                case "Cisne":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cisnee");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cisnei");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/cisne");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Swan: Aquatic bird of approximately 1,50 m of height, with the plumage white or black according to the species, small head, wide bill, orange and black. Change the plumage once a year";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cisne:Ave acuática de aproximadamente 1, 50 m de altura, con el plumaje blanco o negro según la  especie, cabeza pequeña, pico ancho, anaranjado y negro. Muda el plumaje una vez al año";
					});
					break;

                case "Cobra":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cobrae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cobrai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/COBRA");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cobra: Poison reptile characterized by the absence of legs, elongated body, sharp tusks and large head";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cobra: Reptil venenoso caracterizado por la ausencia de patas, cuerpo alargado, colmillos filosos y cabeza grande";
					});
					break;

                case "Cocodrilo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/cocodriloe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/cocodriloi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/cocodrilo2");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cocodrile: Semi-aquatic reptile of great length; His skin has scales, is hard and dry. Is carnivorous and very fearsome for its voracity";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cocodrilo: Reptil semiacuático de gran longitud; su piel tiene escamas, es dura y seca. es carnívoro y muy temible por su voracidad";
					});
					break;

                case "Colibri":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/colibrie");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/colibrii");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/colibri");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Hummingbird: American bird, considered as the smallest in the world, has bright colors and a long and slender beak with a tubular extensible tongue for the nectar of flowers.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Colibrí:  Ave americana, considerada como la más pequeña del mundo, tiene colores brillantes y pico largo y delgado con una lengua tubular extensible para alimentarse del néctar de las flores.";
					});
					break;

                case "Conejo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/conejoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/conejoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Conejo");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Rabbit:A herbivorous mammal characterized by having a body covered with a brown or gray coat. It has long ears which help regulate body temperature.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Conejo: Mamífero herbívoro que se caracteriza por tener un cuerpo cubierto de un pelaje  color café o gris.  Tiene orejas largas las cuales le ayudan a regular la temperatura del cuerpo.";
					});
					break;

				case "Delfin":
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/delfini");
					});
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/delfine");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/delfines2");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Dolphin: Cetacean mammal 2 to 3 m long, with bulky head, small eyes, very large mouth with numerous conical teeth, thin and sharp snout and a single nasal opening. They are great swimmers who feed on fish.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Delfín: Mamífero cetáceo de 2 a 3 m de largo, con cabeza voluminosa, ojos pequeños, boca muy grande con numerosos dientes cónicos, hocico delgado y agudo y una sola abertura nasal. Son grandes nadadores que se alimentan de peces.";
					});
					break;

                case "Elefante":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/elefantee");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/elefantei");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/elefante");
                    });

					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Elephant: Large mammal, grayish skin, rough and thick, with small head and eyes, large and hanging ears, and upper nose and lip attached and prolonged in a trunk that he uses as a hand.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Elefante: Mamífero de gran tamaño, piel grisácea, rugosa y gruesa, con la cabeza y los ojos pequeños, las orejas grandes y colgantes, y la nariz y el labio superior unidos y prolongados en una trompa que usa como mano.";
					});
					break;

                case "Escarabajo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/escarabajoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/escarabajoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/escarabajo");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Beetle: Insect of oval body and generally plump, usually of black or dark color, with six legs, two antennas in the form of mallets, mouth of masticador type and wings protected by hard plates denominated.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Escarabajo: Insecto de cuerpo ovalado y generalmente rechoncho, habitualmente de color negro u oscuro, con seis patas, dos antenas en forma de mazas, boca de tipo masticador y alas protegidas por unas placas duras denominadas.";
					});
					break;

                case "Escorpion":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/escorpione");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/escorpioni");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/escorpion");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Scorpion: Arachnid with four pairs of legs and tail-like back that ends up in a poisonous sting.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Escorpión: Arácnido con cuatro pares de patas y la parte posterior en forma de cola que acaba en un aguijón venenoso.";
					});
					break;

                case "Flamenco":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/flamencoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/flamencoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/flamenco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Flemish: Slender bird of between 1m and 1.30 m which are characterized by having pink plumage, neck and long legs and curved beak, used to filter the water and obtain food.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Flamenco: Ave esbelta de entre 1m y 1,30 m que se caracterizan por tener el plumaje rosado, cuello y patas largos y el pico curvado, que utilizan para filtrar el agua y obtener el alimento.";
					});
				break;

                case "Foca":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/focae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/focai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/leonmarino1");
                    });

					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Seal: Mammal approximately 1 m long, with a finned body and covered with hair, which usually lives in the cold seas.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Foca: Mamífero de aproximadamente 1 m de largo, con el cuerpo dotado de aletas y cubierto de pelo, que habita generalmente en los mares fríos.";
					});
					break;

                case "Gato":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/gatoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/gatoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/gato");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cat: Domestic carnivorous mammal with round head, very rough tongue, short legs armed with strong nails, sharp and retractable, thick and soft coat of various colors and eyes whose pupil dilates to see in the dark";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Gato: Mamífero carnívoro doméstico de cabeza redonda, lengua muy áspera, patas cortas armadas de uñas fuertes, agudas y retráctiles, pelaje espeso y suave de diversos colores y ojos cuya pupila se dilata para ver en la oscuridad";
					});
					break;

                case "Gorila":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/gorilae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/gorilai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/gorila");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Gorilla: Mammal primate of about 2 m of height and dark brown color, It usually moves to four legs. It feeds on leaves and fruits and lives in Africa.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Gorila: Mamífero primate de unos 2 m de altura y color pardo oscuro, Se desplaza generalmente a cuatro patas. Se alimenta de hojas y frutos y habita en África.";
					});
					break;

                case "Grillo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/grilloe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/grilloi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/grillo");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cricket: Night bug up to 3 cm long, black or brown, round head, prominent eyes and legs adapted to the jump.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Grillo: Insecto nocturno de hasta 3 cm de largo, color negro o marrón, cabeza redonda, ojos prominentes y patas adaptadas al salto.";
					});
					break;

                case "Guacamaya":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/guacamayae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/guacamayai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/PERICO");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Guacamaya: Bird of about 40 cm of height, with the curved beak, the very long tail and the plumage of blue, yellow, green and red color. It feeds on insects and berries and lives on trees.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Guacamaya: Ave de unos 40 cm de altura, con el pico curvo, la cola muy larga y el plumaje de color azul, amarillo, verde y rojo. Se alimenta de insectos y bayas y viven en los árboles.";
					});
					break;

                case "Hipopotamo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/hipopotamoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/hipopotamoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/hipo1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Hippopotamus: Aquatic mammal with thick and black skin, bulky body that can reach 3.50 m in length, short legs, large head with ears, eyes and nostrils located at the top, allowing them to breathe When they are in the water";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Hipopótamo:Mamífero acuático de piel gruesa y negruzca, cuerpo voluminoso que puede llegar a alcanzar los 3,50 m de longitud, patas cortas, cabeza grande con las orejas, los ojos y los orificios nasales situados en la parte de arriba, lo que les permite respirar cuando están dentro del agua";
					});
					break;

                case "Hormiga":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/hormigae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/hormigai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Ant: Insect usually of black color, are easily identified by its long legs, its antennas in angle and its structure in three sections with a narrow waist.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Hormiga: Insecto  generalmente de color negro, se identifican fácilmente por sus patas largas, sus antenas en ángulo y su estructura en tres secciones con una estrecha cintura.";
					});
					break;

                case "Jirafa":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/jirafae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/jirafai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Giraffe: Mammal about 5 m tall, with long, slender neck, small head with two little horns developed and yellow fur with dark spots.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Jirafa: Mamífero de unos 5 m de altura, con el cuello largo y esbelto, la cabeza pequeña con dos cuernos poco desarrollados y el pelaje amarillo con manchas oscuras.";
									});
					break;

                case "Leon":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/leone");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/leoni");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/leon");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Lion: Carnivorous mammal that can reach up to 3 m in length, fur between yellow and red, large head with thick mane in males, very strong teeth and nails and long tail";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "León: Mamífero carnívoro que puede alcanzar hasta 3 m de longitud, de pelaje entre amarillo y rojo, cabeza grande con espesa melena en los machos, dientes y uñas muy fuertes y cola larga";
									});
					break;

                case "Leopardo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/leopardoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/leopardoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/leopardo1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Leopard: Carnivorous feline mammal up to 2.50 m long, reddish yellow hair with black and round spots, stylized body and very agile, living in the forests of Asia and Africa.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Leopardo: Mamífero felino carnívoro de hasta 2,50 m de longitud, pelo amarillo rojizo con manchas negras y redondas, cuerpo estilizado y muy ágil, que vive en los bosques de Asia y África.";
									});
					break;

                case "Libelula":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/libelulae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/libelulai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Dragonfly: Insect that measures between 30 and 80 mm, with four equal and transparent wings and elongated abdomen and big eyes. They live in stagnant waters and feed on mosquitoes.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Libélula: Insecto que mide entre 30 y 80 mm, con cuatro alas iguales y transparentes y abdomen alargado y grandes ojos. Viven en las aguas estancadas y se alimentan de mosquitos.";
									});
					break;

                case "Lobo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/loboe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/loboi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/lobo");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Wolf: Carnivorous mammal, dark gray or brown fur, pointed head, stiff ears, strong jaw and long tail with a lot of hair.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Lobo: Mamífero carnívoro, de pelaje gris oscuro o pardo, cabeza aguzada, orejas tiesas, mandíbula fuerte y cola larga con mucho pelo.";
									});
					break;

                case "Manati":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/manatie");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/manatii");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/morsa1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Sea Cow:Mammal of about 3 to 4 m in length, short neck, thick body and hairy skin of very thick; Has the upper extremities in the form of fins finished by hands, and the lower extremities form the caudal fin. They are herbivores and their meat and fat are highly esteemed.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Manatí: Mamífero de unos 3 a 4 m de longitud, cuello corto, cuerpo grueso y piel velluda de mucho espesor; tiene las extremidades superiores en forma de aletas terminadas por manos, y las inferiores forman la aleta caudal. Son herbívoros y su carne y grasa son muy estimadas.";
									});
					break;

                case "Mantaraya":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/mantarrayae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/mantarrayai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Stingray: Cartilaginous fish with flattened body, brownish, reddish or gray, and fins extended in the form of a mantle. They inhabit seas of warm waters all over the world; They feed on plankton, small fish and squid.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Mantarraya: Pez cartilaginoso con el cuerpo aplanado,de color pardusco,rojizo o gris ,y aletas extendidas en forma de manto. Habitan en mares de aguas templadas de todo el mundo; se alimentan de plancton, peces pequeños y calamares. ";
									});
					break;

                case "Mariposa":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/mariposae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/mariposai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Butterfly: Insect with two pairs of membranous wings covered with scales often of colorful colors. It develops in a process known as metamorphosis.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Mariposa: Insecto con dos pares de alas membranosas cubiertas de escamas a menudo de colores vistosos. Se desarrolla en un proceso conocido como metamorfosis.";
									});
					break;

                case "Mariquita":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/mariquitae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/mariquitai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Ladybug: Insect of small body, rounded and blackish underneath, incarnate and brilliant, with black points in the cuirass, two membranous wings, legs and very short antennas.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Mariquita: Insecto de cuerpo pequeño,redondeado y negruzco por debajo,encarnado y brillante,con puntos negros en la coraza, dos alas membranosas, patas y antenas muy cortas.";
									});
					break;

                case "Medusa":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/medusae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/medusai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/medusa");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Jellyfish: Marine animal with gelatinous body shaped like a bell, sometimes prolonged by long tentacles that secrete a poisonous substance.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Medusa: Animal marino de cuerpo gelatinoso con forma de campana,  a veces prolongado por largos tentáculos que segregan una sustancia venenosa.";
									});
					break;

                case "Mosca":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/moscae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/moscai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/mosquito");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Fly: Insect of black body, with two transparent wings, long legs with nails and suckers and mouth shaped like tube to suck and feed.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Mosca: Insecto de cuerpo negro,con dos alas transparentes,patas largas con uñas y ventosas y boca en forma de trompa para chupar y alimentarse.";
									});
					break;

                case "Murcielago":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/murcielagoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/muercielagoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Bat: Flying mammal with membranous wings and nocturnal customs. They are present on all continents except Antarctica. They feed on fruits or small vertebrates.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Murciélago: Mamífero volador de alas membranosas y costumbres nocturna. Están presentes en todos los continentes, excepto en la Antártida. Se alimentan de frutas o pequeños vertebrados.";
									});
					break;

                case "OsoPardo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/osopardoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/osopardoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/osos1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Grizzly: Native American omnivorous mammal. It has a body length of between 1.50 and 2.95 m. The color of its coat can vary between brown and gray. Spend winter in a state of hibernation";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Oso Pardo: Mamífero omnívoro propio de América del Norte. Tiene una longitud corporal de entre 1,50 y 2,95 m. El color de su pelaje puede variar entre el marron y el gris. Pasa el invierno en un estado de hibernación";
									});
					break;

                case "OsoPolar":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/osopolare");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/osopolari");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/osos1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Polar Bear: Carnivorous mammal. It lives in icy areas and swims easily. It has long legs, small ears and tail, and a thick layer of fat and a dense translucent coat that serves to increase body heat";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Oso Polar: Mamífero carnívoro. Habita en zonas heladas y nada con facilidad. Tiene patas largas, orejas y cola pequeñas, y una gruesa capa de grasa y un denso pelaje translúcido que le sirve  para aumentar el calor corporal";
									});
					break;

                case "OsoPanda":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/pandae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/pandai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/pandagigante");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Panda Bear: A vegetarian mammal between 60cm and 1m in length, it has black and white fur. Its front legs are strong and able to climb and longer and muscular than the hind legs";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Oso Panda: Mamífero vegetariano de entre 60cm y 1m de longitud, tiene pelaje blanco y negro. Sus patas delanteras son fuertes y aptas para escalar y más largas y musculosas que las traseras";
									});
					break;

                case "Oveja":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/ovejae");
                    }); ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/ovejai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/ov2");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Sheep: Small ruminant mammal, its body covered with thick and flexible wool, usually white or black; He is raised in domesticity and he is especially profited by wool, meat and milk.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Oveja: Mamífero rumiante pequeño, con el cuerpo cubierto de lana espesa y flexible, generalmente blanca o negra; se cría en domesticidad y de él se aprovechan especialmente la lana, la carne y la leche.";
									});
					break;

                case "Paloma":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/palomae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/palomai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Paloma");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Dove: Domestic bird, small head and sturdy trunk, short beak and short legs with four fingers. It has large and strong wings, with a little black and white plumage.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Paloma: Ave domesticada, de cabeza pequeña y tronco robusto, pico corto y las patas cortas con cuatro dedos. Posee alas grandes y fuertes, con un plumaje de color blanco y negro poco visible.";
									});
					break;

                case "Pato":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/patoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/patoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/quack1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Duck: Flat aquatic bird, broader at the tip than at the base, short neck and legs also short and webbed, are in abundance in the wild and are domesticated with ease.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Pato: Ave acuática de pico aplanado,más ancho en la punta que en la base,cuello corto y patas también cortas y palmeadas, se encuentran en abundancia en estado salvaje y se domestican con facilidad.";
									});
					break;

                case "Perro":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/perroe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/perroi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/Perro");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Dog: Domestic carnivorous mammal, of very different size, shape and coat, product of the different races obtained by hybridization, which is adapted to all regions of the earth, and characterized by its fidelity to man.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Perro: Mamífero carnívoro doméstico, de tamaño, forma y pelaje muy diversos, producto de las distintas razas obtenidas por hibridación, que está adaptado a todas las regiones de la tierra,  y que se caracteriza por su fidelidad al hombre.";
									});
					break;

                case "Pinguino":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/pinguinoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/pinguinoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Pinguino");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Penguin: Non-flying sea bird, measuring between 90 cm and 1 m in length, with dense black plumage, with white belly, webbed feet, and wings suitable for diving. They are distributed mostly in the Southern Hemisphere.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Pingüino: Ave marina no voladora que mide entre 90 cm y 1 m de longitud, con un denso plumaje negro,con el vientre blanco, patas palmeadas, y alas aptas para el buceo. Se distribuyen mayormente en el Hemisferio Sur.";
									});
					break;

                case "Pollo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/polloe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/polloi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/Pollo");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Chicken: Common names are: cock, for the male; Hen, for the female, and chicken, for the subadults. Bird of red and high crest, short, thick and arched. It has abundant and colorful plumage. They are raised mainly by their meat and their eggs";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Pollo: Los nombres comunes son: gallo, para el macho; gallina, para la hembra, y pollo, para los subadultos. Ave de cresta roja y alta, pico corto, grueso y arqueado. Tiene abundante y vistoso plumaje. Se crían principalmente por su carne y por sus huevos";
									});
					break;

                case "Pulpo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/pulpoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/pulpoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Octopus: Invertebrate mollusk that has the body in the form of a sack, with eight arms of great length, and they own a siphon by which they expel water to propel itself or ink to muddy the water when they feel threatened.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Pulpo: Molusco invertebrado que tiene el cuerpo en forma de saco,con ocho brazos de gran longitud,y poseen un sifón por el que expulsan agua para propulsarse o tinta para enturbiar el agua cuando se sienten amenazados.";
									});
					break;

                case "Rinoceronte":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/rinocerontee");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/rinocerontei");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/rino1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Rhino: Herbivorous mammal of up to 5 meters in length, very corpulent, very thick and rigid gray skin; Has short, sturdy legs with three fingers, and one or two large horns curved in the middle of the nose. He lives in Asia and Africa.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Rinoceronte: Mamífero herbívoro de hasta 5 metros de longitud, muy corpulento, de piel muy gruesa y rígida de color gris; tiene patas cortas y robustas con tres dedos, y uno o dos grandes cuernos curvados en medio de la nariz. Vive en Asia y África.";
									});
					break;

                case "Sapo":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/sapoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/sapoi");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/sapo1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Toad: Amphibian of large size, chubby body, thick and warty skin, strong hind legs and bulging eyes. Most spend their lives in or near water.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Sapo: Anfibio de gran tamaño,cuerpo rechoncho, piel gruesa y verrugosa, patas posteriores fuertes y ojos saltones. La mayoría pasa su vida dentro o cerca del agua.";
									});
					break;

                case "Tiburon":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/tiburone");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/tiburoni");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/blanco");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Shark: Cartilaginous fish with a slender body, with gill lateral clefts to silence its movement and mouth located in the lower part of the head, provided with several rows of compressed, sharp and sharp teeth";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tiburón: Pez cartilaginoso de cuerpo esbelto, con hendiduras branquiales laterales para silenciar su movimiento y boca situada en la parte inferior de la cabeza, provista de varias filas de dientes comprimidos, agudos y cortantes";
									});
					break;

                case "Tigre":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/tigree");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/tigrei");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/tigre1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tiger: Carnivorous mammal of about 1.80 m in length plus 1 m of tail, with yellow skin with black stripes on the back and white tail and belly, with great muscular strength and agility for the jump and powerful claws and jaws .";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tigre: Mamífero carnívoro de unos 1, 80 m de longitud más 1 m de cola, con la piel de color amarillo con rayas negras en el lomo y la cola y el vientre blancos, con gran fuerza muscular y agilidad para el salto y poderosas garras y mandíbulas.";
									});
					break;

                case "Tortuga":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/tortugae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/tortugai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Tortuga");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Turtle: Terrestrial, marine or freshwater reptile, characterized by having a broad and short trunk, and a shell that protects the internal organs of its body. The front and front legs of the carapace come from behind, and behind the hind legs and tail.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tortuga: Reptil terrestre, marino o de agua dulce, caracterizado por tener un tronco ancho y corto, y un caparazón que protege los órganos internos de su cuerpo. De su caparazón salen, por delante, la cabeza y las patas delanteras, y por detrás las patas traseras y la cola.";
									});
					break;

                case "Tucan":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/tucane");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/tucani");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/tucan1");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Toucan: A climbing bird with arched bill, very thick and almost as long as the body, with black plumage and bright colors. Measures between 18 and 65 cm. It feeds mainly on fruits";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tucán: Ave trepadora de pico arqueado, muy grueso y casi tan largo como el cuerpo, con plumaje negro y de colores vivos. Mide entre 18 y 65 cm. Se alimenta principalmente de frutas";
									});
					break;

                case "Vaca":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/vacae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/vacai");
                    });
                    ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/Sonidos/vaca");
                    });
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Cow: Domestic mammal, about 150 cm in height and 250 cm in length, very robust body, short hair, thick head with two curved horns, feed mainly on grass. Milk, meat and skin are used";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Vaca: Mamífero doméstico, de unos 150 cm de altura y 250 cm de longitud, cuerpo muy robusto, pelo corto, cabeza gruesa provista de dos cuernos curvos, se alimenta principalmente de pasto. De ella se aprovechan la leche, la carne y la piel";
									});
					break;

                case "Venado":
               
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/venadoe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/venadoi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Venado");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Deer: Lean herbivorous mammal, brown in color, rough and short hair, long legs and very short tail. The male has antlers or horns, which loses and renews every year, increasing over time the number of points, which reach 10 in each pole.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Venado: Mamífero herbívoro esbelto, de color pardo, pelo áspero y corto, patas largas y cola muy corta. El macho tiene astas o cuernos, que pierde y renueva todos los años, aumentando con el tiempo el número de puntas, que llegan a 10 en cada asta.";
									});
					break;

                case "Zorro":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/zorroe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/zorroi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Zorro");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Fox: Carnivorous mammal less than 1 m in length including tail, elongated snout and reddish brown coat and very thick, especially in the tail, white tip.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Zorro: Mamífero carnívoro de menos de 1 m de longitud incluida la cola, hocico alargado y pelaje color pardo rojizo y muy espeso, especialmente en la cola, de punta blanca.";
									});
					break;

                case "Avion":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/avione");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/avioni");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Avión");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Airplane: Vehicle heavier than air, provided with wings, flying propelled by one or more engines";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Avión: Vehículo más pesado que el aire, provisto de alas, que vuela propulsado por uno o varios motores";
									});
					break;

                case "Bicicleta":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/bicicletae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/bicicletai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Bicicleta");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Bike: Vehicle of two wheels generally equal, moved by two pedals and a chain.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Bicicleta: Vehículo de dos ruedas generalmente iguales, movidas por dos pedales y una cadena.";
									});
					break;

                case "Bus":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/buse");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/busi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Autobus");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Bus: Large-capacity public transport vehicle for urban passenger transport on a fixed route";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Bus: Vehículo de transporte público de gran capacidad destinado al transporte urbano de viajeros en un recorrido fijo";
									});
					break;

                case "Carro":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/carroe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/carroi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Carro");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Car: Means of transport having a frame mounted on wheels. For traction of a car it is possible to use animals or motors.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Carro:Medios de transporte que disponen de un armazón montado sobre ruedas. Para la tracción de un carro es posible utilizar animales o motores.";
									});
					break;

                case "Helicoptero":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/helicopteroe");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/helicopteroi");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Helicoptero");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Helicopter: Aircraft characterized by having a propeller with a vertical axis at the top that allows it to remain still, ascend and descend vertically";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Helicóptero:. Aeronave caracterizada por tener una hélice de eje vertical en su parte superior que le permite mantenerse inmóvil, ascender y descender verticalmente";
									});
					break;

                case "Lancha":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/lanchae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/lanchai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/blanco");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Boat: Light motor boat, capable of reaching high speed, used to provide public transport services generally in rural surroundings";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Lancha:  Embarcación ligera de motor, capaz de alcanzar gran velocidad, utilizada para prestar servicios de transporte público generalmente en entorno rural";
									});
					break;

                case "Motocicleta":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/motocicletae");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/motocicletai");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Motocicleta");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Motorcycle: Two-wheeled vehicle powered by a fast-blasting engine, one or two cylinders and fingers or four strokes.";
					}					);
									ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Moto:  Vehículo de dos ruedas propulsado por un motor de explosión rápido, de uno o de dos cilindros y dedos o cuatro tiempos.";
									});
					break;

                case "Taxi":
                
                    ButtonSpanish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos español/taxi");
                    });
                    ButtonEnglish.GetComponent<Button>().onClick.AddListener(delegate {
                        playSound("Sonidos/SonidosIdiomas/sonidos ingles/taxii");
                    });
					ButtonSound.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sonidos/Sonidos/Carro");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Taxi: Car rental with meter and driver, who provides his service inside a city in exchange for money.";
					}
					);ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Taxi: Coche de alquiler provisto de taxímetro y conductor,que presta su servicio dentro de una ciudad a cambio de dinero.";
									});
					break;

				case "Tren":
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos español/trene");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/SonidosIdiomas/sonidos ingles/treni");
					});
					ButtonSound.GetComponent<Button> ().onClick.AddListener (delegate {
						playSound ("Sonidos/Sonidos/Tren");
					});
					ButtonEnglish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Train: Transport consisting of a series of wagons linked or articulated one after another and dragged by a locomotive";
					}
					);
					ButtonSpanish.GetComponent<Button> ().onClick.AddListener (delegate {
						TextDescription.GetComponent<Text> ().text = "Tren: Transporte formado por una serie de vagones enlazados o articulados unos tras otros y arrastrados por una locomotora";
					});
					break; 

				}
            }


        }

//function to play sound
        void playSound(string ss){
            clipTarget = (AudioClip)Resources.Load(ss);
            soundTarget.clip = clipTarget;
            soundTarget.loop = false;  
            soundTarget.playOnAwake = false;
            soundTarget.Play();
        }

    }
}