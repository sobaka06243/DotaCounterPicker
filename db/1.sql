CREATE TABLE public."Heroes"
(
	"Id" integer NOT NULL,
	"Name" character varying(100),
	PRIMARY KEY ("Id"),
	UNIQUE("Name")
);

CREATE TABLE public."Lines"
(
	"Id" integer NOT NULL,
	"Name" character varying(100),
	PRIMARY KEY ("Id"),
	UNIQUE("Name")
);

CREATE TABLE public."HeroesToLines"
(
	"Id" integer NOT NULL,
	"HeroId" integer NOT NULL,
	"LineId" integer NOT NULL,
	UNIQUE("HeroId", "LineId"),
	PRIMARY KEY ("Id"),
	CONSTRAINT fk_HeroesToLines_HeroId_To_Heroes
	FOREIGN KEY("HeroId") REFERENCES public."Heroes"("Id"),
	CONSTRAINT fk_HeroesToLines_LineId_To_Lines
	FOREIGN KEY("LineId") REFERENCES public."Lines"("Id")
);

INSERT INTO "Heroes" ("Id", "Name") VALUES
	(1, 'abaddon'),
	(2, 'alchemist'),
	(3, 'ancient-apparition'),
	(4, 'anti-mage'),
	(5, 'arc-warden'),
	(6, 'axe'),
	(7, 'bane'),
	(8, 'batrider'),
	(9, 'beastmaster'),
	(10, 'bloodseeker'),
	(11, 'bounty-hunter'),
	(12, 'brewmaster'),
	(13, 'bristleback'),
	(14, 'broodmother'),
	(15, 'centaur-warrunner'),
	(16, 'chaos-knight'),
	(17, 'chen'),
	(18, 'clinkz'),
	(19, 'clockwerk'),
	(20, 'crystal-maiden'),
	(21, 'dark-seer'),
	(22, 'dark-willow'),
	(23, 'dawnbreaker'),
	(24, 'dazzle'),
	(25, 'death-prophet'),
	(26, 'disruptor'),
	(27, 'doom'),
	(28, 'dragon-knight'),
	(29, 'drow-ranger'),
	(30, 'earthshaker'),
	(31, 'earth-spirit'),
	(32, 'elder-titan'),
	(33, 'ember-spirit'),
	(34, 'enchantress'),
	(35, 'enigma'),
	(36, 'faceless-void'),
	(37, 'grimstroke'),
	(38, 'gyrocopter'),
	(39, 'hoodwink'),
	(40, 'huskar'),
	(41, 'invoker'),
	(42, 'io'),
	(43, 'jakiro'),
	(44, 'juggernaut'),
	(45, 'keeper-of-the-light'),
	(46, 'kunkka'),
	(47, 'legion-commander'),
	(48, 'leshrac'),
	(49, 'lich'),
	(50, 'lifestealer'),
	(51, 'lina'),
	(52, 'lion'),
	(53, 'lone-druid'),
	(54, 'luna'),
	(55, 'lycan'),
	(56, 'magnus'),
	(57, 'marci'),
	(58, 'mars'),
	(59, 'medusa'),
	(60, 'meepo'),
	(61, 'mirana'),
	(62, 'monkey-king'),
	(63, 'morphling'),
	(64, 'muerta'),
	(65, 'naga-siren'),
	(66, 'natures-prophet'),
	(67, 'necrophos'),
	(68, 'night-stalker'),
	(69, 'nyx-assassin'),
	(70, 'ogre-magi'),
	(71, 'omniknight'),
	(72, 'oracle'),
	(73, 'outworld-destroyer'),
	(74, 'pangolier'),
	(75, 'phantom-assassin'),
	(76, 'phantom-lancer'),
	(77, 'phoenix'),
	(78, 'primal-beast'),
	(79, 'puck'),
	(80, 'pudge'),
	(81, 'pugna'),
	(82, 'queen-of-pain'),
	(83, 'razor'),
	(84, 'riki'),
	(85, 'rubick'),
	(86, 'sand-king'),
	(87, 'shadow-demon'),
	(88, 'shadow-fiend'),
	(89, 'shadow-shaman'),
	(90, 'silencer'),
	(91, 'skywrath-mage'),
	(92, 'slardar'),
	(93, 'slark'),
	(94, 'snapfire'),
	(95, 'sniper'),
	(96, 'spectre'),
	(97, 'spirit-breaker'),
	(98, 'storm-spirit'),
	(99, 'sven'),
	(100, 'techies'),
	(101, 'templar-assassin'),
	(102, 'terrorblade'),
	(103, 'tidehunter'),
	(104, 'timbersaw'),
	(105, 'tinker'),
	(106, 'tiny'),
	(107, 'treant-protector'),
	(108, 'troll-warlord'),
	(109, 'tusk'),
	(110, 'underlord'),
	(111, 'undying'),
	(112, 'ursa'),
	(113, 'vengeful-spirit'),
	(114, 'venomancer'),
	(115, 'viper'),
	(116, 'visage'),
	(117, 'void-spirit'),
	(118, 'warlock'),
	(119, 'weaver'),
	(120, 'windranger'),
	(121, 'winter-wyvern'),
	(122, 'witch-doctor'),
	(123, 'wraith-king'),
	(124, 'zeus');
	
INSERT INTO "Lines" ("Id", "Name") VALUES
	(1, 'Легкая линия'),
	(2, 'Сложная линия'),
	(3, 'Центральная линия'),
	(4, 'Лес');