﻿USE CarService
GO

TRUNCATE TABLE CarModel
GO

INSERT INTO CarModel (BrandId, Model) VALUES
('1', '60 (1965–1972)')
,('1', '100 (1968–1978)')
,('1', '80 (1972–1978)')
,('1', '50 (1974–1978)')
,('1', '100 (1969– 1976)')
,('1', '100 Coupé S (1967–1974)')
,('1', '80 (1978–1986)')
,('1', '200 5T (1979–1984)')
,('1', '100 (1982–1990)')
,('1', '80 quattro (1980–1987)')
,('1', '90 (1984–1987)')
,('1', 'Coupe GT (1980–1987)')
,('1', 'Sport quattro (1983–1984)')
,('1', '80 (1986–1991)')
,('1', '90 (1986–1991)')
,('1', 'V8 (1988–1995)')
,('1', 'Coupe (1988–1995)')
,('1', '100 Duo (hybrid) (1989)')
,('1', '100/A6 (1991–1998)')
,('1', '80 (1991–1996)')
,('1', 'Cabriolet (1990–2000)')
,('1', 'A8 (1994–2003)')
,('1', 'A4 (1994–2001)')
,('1', 'A3 (1996–2003)')
,('1', 'A6 (1997–2006)')
,('1', 'A4 Duo (hybrid) (1997)')
,('1', 'TT Coupe (1998–2006)')
,('1', 'TT Roadster (1999–2006)')
,('1', 'A2 (1999–2006)')
,('1', 'A4 (2001–2007)')
,('1', 'A4 Cabriolet (2001–2005)')
,('1', 'A8 (2003–2010)')
,('1', 'A3 (2003–)')
,('1', 'A6 (2004–2008)')
,('1', 'A3 Sportback (2005–)')
,('1', 'Q7 (2005–)')
,('1', 'A6 allroad quattro (2006–2011)')
,('1', 'A4 Cabriolet (2005–2009)')
,('1', 'TT (2006–)')
,('1', 'A4 (2007–)')
,('1', 'A5 (2007–)')
,('1', 'Q5 (2008–)')
,('1', 'TT 2.0 TDI quattro (2008–)')
,('1', 'A6 (2008–2011)')
,('1', 'A6 Cabriolet (2008–)')
,('1', 'A4 allroad quattro (2009–)')
,('1', 'R8')
,('1', 'R8 V10')
,('1', 'A1 (2010–)')
,('1', 'A3 (2016—)')
,('1', 'A4 (2011—2015)')
,('1', 'A4 (2015—)')
,('1', 'A5 (2017—)')
,('1', 'A6 (2011—)')
,('1', 'A7 (2010—2018)')
,('1', 'A7 (2018—)')
,('1', 'A8 (2010—2018)')
,('1', 'A8 (2018—)')
,('1', 'Q2 (2017—)')
,('1', 'Q3 (2011—)')
,('1', 'A6 allroad quattro (2012—)')
,('1', 'Q7 (2015—)')
,('1', 'R8 (2015—)')
,('1', 'TT (2017—)')
,('1', 'Q8 (2018—)')
,('2', '1 (F20)')
,('2', '2')
,('2', 'F45')
,('2', '3')
,('2', '4')
,('2', 'M4')
,('2', '5')
,('2', '5 Series Gran Turismo')
,('2', '6')
,('2', '6 (F13)')
,('2', '7')
,('2', '8')
,('2', '320si WTCC')
,('2', '328')
,('2', '501/502')
,('2', '503')
,('2', '507')
,('2', '700')
,('2', '3200 CS')
,('2', 'ActiveHybrid 7')
,('2', 'E3 и E9')
,('2', 'E12')
,('2', 'E21')
,('2', 'E23')
,('2', 'E24')
,('2', 'E28')
,('2', 'E30')
,('2', 'E31')
,('2', 'E32')
,('2', 'E34')
,('2', 'E36')
,('2', 'E38')
,('2', 'E39')
,('2', 'E46')
,('2', 'E60')
,('2', 'E65/E66')
,('2', 'E87')
,('2', 'E90')
,('2', 'E92')
,('2', 'F01')
,('2', 'F10')
,('2', 'F22/F23')
,('2', '3-й серии (F30)')
,('2', 'F34')
,('2', '3-й серии (G20)')
,('2', 'G30')
,('2', 'GINA')
,('2', 'Hydrogen 7')
,('2', 'i3')
,('2', 'i8')
,('2', 'Isetta')
,('2', 'M1')
,('2', 'M3')
,('2', 'M5')
,('2', 'M6')
,('2', 'Neue Klasse')
,('2', 'X1')
,('2', 'X3')
,('2', 'X4')
,('2', 'X5 (E53)')
,('2', 'X5 (F15)')
,('2', 'X5 (E70)')
,('2', 'X6')
,('2', 'X7')
,('2', 'Z')
,('2', 'Z1')
,('2', 'Z4')
,('2', 'Z8')
,('3', '7W')
,('3', '7Y')
,('3', '999')
,('3', 'Aerostar')
,('3', 'Airstream')
,('3', 'Anglia')
,('3', 'Aspire')
,('3', 'B-Max')
,('3', 'Bantam')
,('3', 'C-Max')
,('3', 'C1')
,('3', 'Capri')
,('3', 'Cargo')
,('3', 'Comète')
,('3', 'Consul')
,('3', 'Consul Classic')
,('3', 'Contour')
,('3', 'Corsair')
,('3', 'Cougar')
,('3', 'Country Sedan')
,('3', 'Country Squire')
,('3', 'Courier')
,('3', 'Crown Victoria')
,('3', 'CX')
,('3', 'Del Rey')
,('3', 'Del Rio')
,('3', 'EcoSport')
,('3', 'Edge')
,('3', 'Eifel')
,('3', 'Elite')
,('3', 'Escape Hybrid')
,('3', 'Escort (Европа)')
,('3', 'Escort (Северная Америка)')
,('3', 'Excursion')
,('3', 'Expedition')
,('3', 'Explorer')
,('3', 'F-Series')
,('3', 'Fairlane (США)')
,('3', 'Fairmont')
,('3', 'Falcon (Австралия)')
,('3', 'Falcon (Аргентина)')
,('3', 'Falcon (США)')
,('3', 'Festiva')
,('3', 'Fiesta')
,('3', 'Figo')
,('3', 'Five Hundred')
,('3', 'Flex')
,('3', 'Focus')
,('3', 'Focus (Северная Америка)')
,('3', 'Puma (2019)')
,('3', 'Streetka')
,('3', 'Transit Custom')
,('3', 'Fusion')
,('3', 'Fusion (Северная Америка)')
,('3', 'Galaxie')
,('3', 'Galaxy')
,('3', 'Granada (Северная Америка)')
,('3', 'GT')
,('3', 'GT40')
,('3', 'Ikon')
,('3', 'Ka')
,('3', 'Kuga')
,('3', 'Laser')
,('3', 'LTD (Северная Америка)')
,('3', 'LTD Crown Victoria')
,('3', 'LTD II')
,('3', 'Maverick')
,('3', 'Model A (1903)')
,('3', 'Model A (1927)')
,('3', 'Model AA')
,('3', 'Model B (1904)')
,('3', 'Model B (1932)')
,('3', 'Model C')
,('3', 'Model C Ten')
,('3', 'Model F')
,('3', 'Model K')
,('3', 'Model N')
,('3', 'Model T')
,('3', 'Model TT')
,('3', 'Model Y')
,('3', 'Mondeo')
,('3', 'Mustang')
,('3', 'Nucleon')
,('3', 'Orion')
,('3', 'Parklane')
,('3', 'Pilot')
,('3', 'Pinto')
,('3', 'Popular')
,('3', 'Probe')
,('3', 'Puma')
,('3', 'Quadricycle')
,('3', 'Ranch Wagon')
,('3', 'Ranchero')
,('3', 'Ranger')
,('3', 'Rheinland')
,('3', 'S-Max')
,('3', 'Scorpio')
,('3', 'Sierra')
,('3', 'Taunus')
,('3', 'Taurus')
,('3', 'Taurus X')
,('3', 'Tempo')
,('3', 'Thunderbird')
,('3', 'Torino')
,('3', 'Tourneo Connect')
,('3', 'Transit')
,('3', 'Transit Connect')
,('3', 'Vedette')
,('3', 'Verona')
,('3', 'Windstar')
,('3', 'Zephyr')
,('4', 'Accord')
,('4', 'Avancier')
,('4', 'City')
,('4', 'Civic')
,('4', 'Civic Si')
,('4', 'Civic Type R')
,('4', 'Concerto')
,('4', 'CR-V')
,('4', 'CR-X')
,('4', 'CR-Z')
,('4', 'Crossroad')
,('4', 'Crosstour')
,('4', 'Element')
,('4', 'Elysion')
,('4', 'FCX Clarity')
,('4', 'Fit')
,('4', 'FR-V')
,('4', 'Freed')
,('4', 'Grace')
,('4', 'HR-V')
,('4', 'Integra')
,('4', 'Vigor')
,('4', 'Civic (шестое поколение)')
,('4', 'Insight')
,('4', 'Inspire')
,('4', 'Jazz')
,('4', 'Legend')
,('4', 'Logo')
,('4', 'N-BOX Slash')
,('4', 'N-ONE')
,('4', 'N-WGN')
,('4', 'NSX')
,('4', 'Odyssey')
,('4', 'Orthia')
,('4', 'Pilot')
,('4', 'Prelude')
,('4', 'Rafaga')
,('4', 'Ridgeline')
,('4', 'S-MX')
,('4', 'S2000')
,('4', 'Shuttle')
,('4', 'Stream')
,('4', 'Torneo')
,('4', 'Zest')
,('5', 'Accent')
,('5', 'Atos')
,('5', 'Chorus')
,('5', 'County')
,('5', 'Coupé')
,('5', 'Creta')
,('5', 'Dynasty')
,('5', 'Elantra')
,('5', 'Entourage')
,('5', 'Eon')
,('5', 'Equus')
,('5', 'Galloper')
,('5', 'Genesis')
,('5', 'Genesis Coupe')
,('5', 'Genesis G70')
,('5', 'Getz')
,('5', 'Grandeur')
,('5', 'H-1')
,('5', 'H-100')
,('5', 'HB20')
,('5', 'Aero Town')
,('5', 'Aura')
,('5', 'Trajet')
,('5', 'i10')
,('5', 'i20')
,('5', 'i30')
,('5', 'i40')
,('5', 'ix20')
,('5', 'Tucson')
,('5', 'ix55')
,('5', 'Kona')
,('5', 'Marcia')
,('5', 'Matrix')
,('5', 'HD65/HD72')
,('5', 'Porter')
,('5', 'Santa Fe')
,('5', 'Solaris')
,('5', 'Sonata')
,('5', 'Stellar')
,('5', 'Terracan')
,('5', 'Veloster')
,('5', 'Verna')
,('6', '4x4 3D')
,('6', '4x4 3D Urban')
,('6', '4x4 Bronto')
,('6', '4x4 5D')
,('6', '4x4 5D Urban')
,('6', 'Niva')
,('6', 'Niva Off-Road')
,('6', 'Granta')
,('6', 'Largus')
,('6', 'Vesta Sedan')
,('6', 'Vesta Cross')
,('6', 'Vesta CNG')
,('6', 'Vesta Sport')
,('6', 'Vesta SW')
,('6', 'Vesta SW Cross')
,('6', 'XRAY')
,('6', 'XRAY Cross')
,('6', '2101')
,('6', '2102')
,('6', '2103')
,('6', '2106')
,('6', '2105')
,('6', '2104')
,('6', '2107')
,('6', '2108')
,('6', '2109')
,('6', '21099')
,('6', '1111')
,('6', '110')
,('6', '111')
,('6', '112')
,('6', '112 Coupe')
,('6', 'Samara')
,('6', 'Kalina')
,('6', 'Priora')
,('6', 'Granta Sport')
,('7', '2')
,('7', '3')
,('7', '3 MPS')
,('7', '5')
,('7', '6')
,('7', '121')
,('7', 'Bongo')
,('7', 'Bongo Friendee')
,('7', 'Capella')
,('7', 'Cosmo')
,('7', 'CX-3')
,('7', 'CX-5')
,('7', 'CX-7')
,('7', 'CX-9')
,('7', 'Familia')
,('7', 'Luce')
,('7', 'CX-30')
,('7', 'MX-30')
,('7', 'Scrum')
,('7', 'MPV')
,('7', 'Roadpacer')
,('7', 'RX-7')
,('7', 'RX-8')
,('7', 'Verisa')
,('7', 'Xedos')
,('8', 'A-Class 1997-')
,('8', 'C-Class 1993-')
,('8', 'CLK-Class 1998-')
,('8', 'E-Class 1995-')
,('8', 'SL-Class 1989-2001')
,('8', 'Vaneo 1997-2004')
,('8', 'A-Class W168 2000-2004')
,('8', 'A-Class W169 2004-')
,('8', 'B-Class 2005-')
,('8', 'C-Class W203 2000-2007')
,('8', 'C-Class W204 2007-')
,('8', 'CL-Class W215 2000-2006')
,('8', 'CL-Class W216 2007-')
,('8', 'CLK-Class 2000-')
,('8', 'CLS-Class 2004-')
,('8', 'E-Class W210 1995-2002')
,('8', 'E-Class W211 2003-2009')
,('8', 'E-Class W212 2009-')
,('8', 'G-Class 2000-')
,('8', 'GL-Class X164 2007-')
,('8', 'M-Class W163 1998-2005')
,('8', 'M-Class W164 2006-')
,('8', 'R-Class 2006-')
,('8', 'S-Class W220 1999-2005')
,('8', 'S-Class W221 2006-2013')
,('8', 'S-Class W222 2013-2019')
,('8', 'S-Class W223 2020-202?')
,('8', 'SLK-Class R170 1998-2004')
,('8', 'SLK-Class R171 2005-')
,('8', 'SL-Class 2001-')
,('8', 'R230')
,('8', 'SLR-McLaren 2003-2009')
,('8', '722 Edition 2006-2009')
,('8', 'SLS AMG 2010-')
,('8', 'SLS AMG 2010-2013')
,('8', 'CLA-Class ')
,('8', 'GLA-Class ')
,('8', 'SL-Class ')
,('8', 'R231')
,('8', 'L-serial NG (Neue Generation)')
,('8', 'L-serial SK (Schwere Klasse)')
,('8', 'Atego')
,('8', 'Axor')
,('8', 'Actros')
,('8', 'Econic')
,('8', 'Unimog')
,('8', 'Zetros')
,('9', 'ASX')
,('9', 'Carisma')
,('9', 'Delica')
,('9', 'Diamante')
,('9', 'Dingo')
,('9', 'Dion')
,('9', 'Eclipse')
,('9', 'Endeavor')
,('9', 'Galant')
,('9', 'i')
,('9', 'Jeep')
,('9', 'L200')
,('9', 'Lancer')
,('9', 'Lancer Evolution')
,('9', 'Minica')
,('9', 'Mirage')
,('9', '500')
,('9', 'Eclipse Cross')
,('9', 'eK')
,('9', 'HSR')
,('9', 'Magna')
,('9', 'Model A')
,('9', 'Outlander')
,('9', 'Pajero')
,('9', 'Pajero Mini')
,('9', 'Pajero Sport')
,('9', 'Space Runner')
,('9', 'Space Star')
,('9', 'Tredia')
,('9', 'Type 73')
,('10', '180SX')
,('10', '300ZX')
,('10', '350Z')
,('10', '370Z')
,('10', 'Almera')
,('10', 'Altima Hybrid')
,('10', 'Armada')
,('10', 'Avenir')
,('10', 'Bluebird')
,('10', 'Bluebird Sylphy')
,('10', 'Caravan Elgrand')
,('10', 'Cedric')
,('10', 'Cefiro')
,('10', 'Cube')
,('10', 'DeltaWing')
,('10', 'Fairlady Z')
,('10', 'Figaro')
,('10', 'Fuga')
,('10', 'Gloria')
,('10', 'GT-R')
,('10', 'GT-R LM Nismo')
,('10', 'Juke')
,('10', 'Laurel')
,('10', 'Laurel Spirit')
,('10', 'LEAF')
,('10', 'Leopard')
,('10', 'Liberty')
,('10', 'Livina')
,('10', 'Maxima')
,('10', 'Micra')
,('10', 'Mistral')
,('10', 'Murano')
,('10', 'Atlas')
,('10', 'Kicks')
,('10', 'Pintara')
,('10', 'Presage')
,('10', 'Pulsar')
,('10', 'Rasheen')
,('10', 'S30')
,('10', 'Sentra')
,('10', 'Note')
,('10', 'NV200')
,('10', 'Pao')
,('10', 'Pathfinder')
,('10', 'Patrol')
,('10', 'Pixo')
,('10', 'President')
,('10', 'Primera')
,('10', 'Prince Royal')
,('10', 'Pulsar GTI-R')
,('10', 'Qashqai')
,('10', 'Quest')
,('10', 'R’nessa')
,('10', 'Rogue Warrior Project')
,('10', 'Serena')
,('10', 'Silvia')
,('10', 'Skyline')
,('10', 'Stagea')
,('10', 'Stanza')
,('10', 'Sunny')
,('10', 'Teana')
,('10', 'Terrano')
,('10', 'Tiida')
,('10', 'Titan')
,('10', 'Vanette')
,('10', 'Wingroad')
,('10', 'X-Trail')
,('10', 'Xterra')
,('11', '3')
,('11', '4')
,('11', '5')
,('11', '7')
,('11', '12')
,('11', '16')
,('11', '19')
,('11', '20/30')
,('11', '21')
,('11', '25')
,('11', '1000 kg')
,('11', 'Alpine GTA/A610')
,('11', 'Avantime')
,('11', 'Captur')
,('11', 'Caravelle / Floride')
,('11', 'Clio')
,('11', 'Dauphine')
,('11', 'Duster')
,('11', 'Espace')
,('11', 'Estafette')
,('11', 'Fluence')
,('11', 'Frégate')
,('11', 'Fuego')
,('11', 'Kangoo')
,('11', 'Koleos')
,('11', 'Laguna')
,('11', 'Latitude')
,('11', 'Logan')
,('11', 'Magnum')
,('11', 'Master')
,('11', 'Mégane')
,('11', 'Midlum')
,('11', 'Modus')
,('11', 'NN')
,('11', 'PN')
,('11', 'Kaptur')
,('11', '4CV')
,('11', 'AHN')
,('11', 'Arkana')
,('11', 'Celtaquatre')
,('11', 'Juvaquatre')
,('11', 'Kadjar')
,('11', 'KJ')
,('11', 'Monaquatre')
,('11', 'Monasix')
,('11', 'MT')
,('11', 'Vel Satis')
,('11', 'Safrane')
,('11', 'Sandero')
,('11', 'Scénic')
,('11', 'Sherpa 2')
,('11', 'Spider')
,('11', 'T')
,('11', 'Talisman')
,('11', 'Taxi de la Marne')
,('11', 'Trafic')
,('11', 'Twingo')
,('11', 'Twizy')
,('11', 'Wind')
,('11', 'ZOE')
,('12', 'Citigo')
,('12', 'Rapid')
,('12', 'Octavia')
,('12', 'Fabia')
,('12', 'Superb')
,('12', 'Kodiaq')
,('12', 'Karoq')
,('12', 'Scalaruen')
,('12', 'Kamiqruen')
,('13', '4Runner')
,('13', '2000GT')
,('13', 'Agya')
,('13', 'Allion')
,('13', 'Alphard')
,('13', 'Aqua')
,('13', 'Aurion')
,('13', 'Auris')
,('13', 'Avalon')
,('13', 'Avensis')
,('13', 'Aygo')
,('13', 'bB')
,('13', 'Belta')
,('13', 'Brevis')
,('13', 'Caldina')
,('13', 'Camry')
,('13', 'Camry Solara')
,('13', 'Carina')
,('13', 'Carina ED')
,('13', 'Celica')
,('13', 'Celica GT-Four')
,('13', 'Century')
,('13', 'Chaser')
,('13', 'Corolla')
,('13', 'Corolla (E170)')
,('13', 'Corolla Spacio')
,('13', 'Corona')
,('13', 'Cressida')
,('13', 'Cresta')
,('13', 'Crown')
,('13', 'Crown Majesta')
,('13', 'Curren')
,('13', 'Cynos')
,('13', 'Duet')
,('13', 'Dyna')
,('13', 'eCom')
,('13', 'Fine-N')
,('13', 'Fine-X')
,('13', 'FJ Cruiser')
,('13', 'Fortuner')
,('13', 'FT-HS')
,('13', 'Gaia')
,('13', 'Harrier')
,('13', 'Highlander')
,('13', 'Hilux')
,('13', 'Hybrid X')
,('13', 'Ipsum')
,('13', 'iQ')
,('13', 'Isis')
,('13', 'Land Cruiser')
,('13', 'Land Cruiser Prado')
,('13', 'LiteAce')
,('13', 'Mark II')
,('13', 'Mark II Qualis')
,('13', 'Mark X')
,('13', 'Mirai')
,('13', 'MR2')
,('13', 'Opa')
,('13', 'Passo')
,('13', 'Picnic')
,('13', 'Pixis Epoch')
,('13', 'Pixis Space')
,('13', 'PM')
,('13', 'Porte')
,('13', 'Premio')
,('13', 'Previa')
,('13', 'Prius')
,('13', 'Prius (gen1)')
,('13', 'Prius (gen2)')
,('13', 'Prius (gen3)')
,('13', 'Prius (gen4)')
,('13', 'Prius PHV')
,('13', 'Prius α')
,('13', 'Probox')
,('13', 'Progres')
,('13', 'Publica')
,('13', 'Ractis')
,('13', 'Raum')
,('13', 'RAV4')
,('13', 'RAV4 EV')
,('13', 'Rush')
,('13', 'SAI')
,('13', 'Sequoia')
,('13', 'Sienna')
,('13', 'Soarer')
,('13', 'Sports 800')
,('13', 'Corolla AE')
,('13', 'Sprinter')
,('13', 'Sprinter Marino')
,('13', 'Succeed')
,('13', 'Supra')
,('13', 'Tacoma')
,('13', 'Tercel')
,('13', 'Corolla (E140)')
,('13', 'Nadia')
,('13', 'ProAce')
,('13', 'Town Ace')
,('13', 'TS050 Hybrid')
,('13', 'Tundra')
,('13', 'Urban Cruiser')
,('13', 'Venza')
,('13', 'Verossa')
,('13', 'Vista')
,('13', 'Vista V20')
,('13', 'WISH')
,('13', 'Yaris')
,('14', 'Amarok')
,('14', 'Beetle (A5)')
,('14', 'Caddy')
,('14', 'Crafter')
,('14', 'Eos')
,('14', 'Fox')
,('14', 'Gol')
,('14', 'Golf')
,('14', 'Golf I')
,('14', 'Golf IV')
,('14', 'Golf Plus')
,('14', 'Golf VI')
,('14', 'Golf VII')
,('14', 'Iltis')
,('14', 'Jetta')
,('14', 'Käfer')
,('14', 'Lupo')
,('14', 'Microbus Concept')
,('14', 'Passat')
,('14', 'Passat Lingyu')
,('14', 'Polo')
,('14', 'Polo Sedan (2010)')
,('14', 'Corrado')
,('14', 'Scirocco')
,('14', 'Sharan')
,('14', 'Tiguan')
,('14', 'Transporter')
,('14', 'Typ 82')
,('14', 'up!')
,('14', 'Arteon')
,('14', 'Golf II')
,('14', 'Golf III')
,('14', 'Golf V')
,('14', 'Golf VIII')
,('14', 'Group MQB')
,('14', 'Karmann-Ghia')
,('14', 'Passat CC')
,('14', 'Teramont')
,('14', 'Touareg')
,('14', 'Touran')
,('14', 'Typ 4')
,('14', 'Typ 166')
GO
