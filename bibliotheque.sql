--
-- PostgreSQL database dump
--

-- Dumped from database version 9.6.1
-- Dumped by pg_dump version 9.6.1

SET statement_timeout = 0;
SET lock_timeout = 0;
SET idle_in_transaction_session_timeout = 0;
SET client_encoding = 'UTF8';
SET standard_conforming_strings = on;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET row_security = off;

--
-- Name: plpgsql; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS plpgsql WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION plpgsql; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION plpgsql IS 'PL/pgSQL procedural language';


--
-- Name: adminpack; Type: EXTENSION; Schema: -; Owner: 
--

CREATE EXTENSION IF NOT EXISTS adminpack WITH SCHEMA pg_catalog;


--
-- Name: EXTENSION adminpack; Type: COMMENT; Schema: -; Owner: 
--

COMMENT ON EXTENSION adminpack IS 'administrative functions for PostgreSQL';


SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- Name: question; Type: TABLE; Schema: public; Owner: qvgdm
--

CREATE TABLE question (
    id integer NOT NULL,
    nom text
);


ALTER TABLE question OWNER TO qvgdm;

--
-- Name: reponse; Type: TABLE; Schema: public; Owner: qvgdm
--

CREATE TABLE reponse (
    id_rep integer NOT NULL,
    type_rep boolean,
    nom text,
    question integer
);


ALTER TABLE reponse OWNER TO qvgdm;

--
-- Data for Name: question; Type: TABLE DATA; Schema: public; Owner: qvgdm
--

COPY question (id, nom) FROM stdin;
4	Quelle est la particularité d'un carré ?
6	Qui était le président de la république française en 2018 ?
7	Dans quelle ville se trouve le stade surnommé 'le chaudron' ?
8	Qui est le créateur de Facebook ?
9	Parmi ces propositions, laquelle désigne un chef-lieu de canton des Alpes-maritimes ?
10	Quel est le nom de la capitale du Kazakhstan depuis le 20 mars 2019 ?
11	Quel était le nom de la capitale du Kazakhstan avant le 20 mars 2019 ?
12	Qu'est-ce qui gravite autour de la Terre ?
13	Qui a peint la Joconde ?
17	Combien y a-t-il de carrés sur un Rubik's Cube classique ?
15	2 + 2 = 
18	Qu'est-ce qu'un graphe en mathématiques ?
1	En France, les révolutionnaires les plus engagés étaient surnommés :
2	Dans la mythologie, Méduse avait le pouvoir de transformer celui qui la regardait en :
3	Dans quelle ville ont eu lieu les J.O. d'été en 2012 ?
5	Sur quelle commune la célèbre plage de Pampelonne est-elle située ?
14	Dans les jeux vidéo dont il est le héros, Mario a :
16	Une personne qui pratique l'élevage des coquillages comestibles est un :
19	Si on croise un élu avec son écharpe tricolore, le rouge près du col indique qu'il est :
20	En boucherie, quel morceau provient de la patte arrière du boeuf ?
21	Quelle expression ne désigne pas un moment de la journée ?
22	Charlie, du livre 'Où est Charlie?' a :
24	Sur le tableau de bord d'un véhicule, le voyant (P) correpond :
25	Quelle confiserie est la spécialité de Montélimar ?
26	Si on suit rigoureusement la règle de grammaire, il faut écrire : 'Il s'est endormi après ...' 
27	Lequel de ces départements n'est pas du tout traversé par la Loire ?
28	Le nom de 'Gendarmerie Nationale' a fait son apparition en France sous
23	Sur le célèbre tableau 'La Joconde', celle-ci a :
\.


--
-- Data for Name: reponse; Type: TABLE DATA; Schema: public; Owner: qvgdm
--

COPY reponse (id_rep, type_rep, nom, question) FROM stdin;
48	f	un twix	12
79	f	le tendron	20
80	t	la tranche	20
81	f	Au chant du coq	21
82	t	 Du coq à l'âne	21
16	f	La reponse D	4
83	f	Entre chien et loup	21
13	t	4 côtés égaux et 4 angles droits	4
84	f	Dès potron-minet	21
85	t	des lunettes	22
15	f	c'est un triangle à 4 côtés	4
14	f	0 au carré ça fait toujours 0 hein	4
86	f	une barbe	22
87	f	une casquette	22
21	f	Sarkozy	6
22	t	Macron	6
23	f	Hollande	6
24	f	Trump	6
25	f	Londres	7
26	f	Monaco	7
27	f	Paris	7
28	t	Saint-Etienne	7
29	f	Alexandre Benalla	8
30	t	Mark Zuckerberg	8
31	f	Evan Spiegel	8
32	f	Bill Gates	8
33	f	Front	9
34	f	Pommette	9
35	f	Cou	9
36	t	Menton	9
37	t	Noursoultan	10
38	f	Astana	10
39	f	Tachkent	10
40	f	Rabat	10
41	f	Prague	11
42	t	Astana	11
43	f	Ankara	11
44	f	Noursoultan	11
45	f	le soleil	12
46	t	la lune	12
47	f	mars	12
49	t	Léonard de Vinci	13
50	f	le groupe Vinci autoroutes	13
51	f	Picasso	13
52	f	Cezanne	13
65	f	9	17
66	t	81	17
67	f	42	17
68	t	54	17
57	f	3	15
58	t	4	15
59	f	7	15
60	f	ln(2), soit 0.69314718056	15
69	f	une courbe en 3D	18
70	f	un axe x,y gradué 	18
71	f	un gps	18
72	t	un ensemble de sommets reliés par des arêtes	18
88	f	des taches de rousseur	22
89	f	les oreilles décollées	23
90	f	une courte frange	23
91	t	la bouche fermée	23
1	f	sans-chemises	1
92	f	les yeux bleus	23
93	f	à la pression d'huile	24
4	f	sans-chaussettes	1
94	f	au préchauffage	24
96	f	au liquide de frein	24
95	t	au frein à main	24
3	t	sans-culottes	1
2	f	sans-pantalons	1
5	f	eau	2
6	f	verre	2
8	f	or	2
7	t	pierre	2
11	t	Londres	3
12	f	Rio	3
9	f	Berlin	3
10	f	Paris	3
97	t	Le nougat	25
98	f	Le caramel	25
17	f	Fréjus	5
18	f	Saint-Tropez	5
19	f	Sainte-Maxime	5
20	t	Ramatuelle	5
53	f	des chaussures rouges	14
54	f	une casquette verte	14
55	t	des gants blancs	14
56	f	une salopette verte	14
99	f	Le sucre d'orge	25
61	f	conchilyculteur	16
62	t	conchyliculteur	16
63	f	conchylliculteur	16
64	f	conchilliculteur	16
73	f	Maire	19
74	t	Député	19
75	f	Conseiller municipal	19
76	f	Conseiller régional	19
77	f	le rumsteak	20
78	f	le filet	20
100	f	Les calissons	25
102	f	qu'elle parte	26
103	f	qu'elle eût partie	26
101	t	qu'elle est partie	26
104	f	qu'elle soit partie	26
105	t	L'Eure-et-Loir	27
106	f	Le Loiret	27
107	f	Le Loir-et-Cher	27
108	f	La Nièvre	27
109	f	Louis XIV	28
110	t	La Révolution Française	28
111	f	Le Ier Empire	28
112	f	La IIIe République	28
\.


--
-- Name: question pkey; Type: CONSTRAINT; Schema: public; Owner: qvgdm
--

ALTER TABLE ONLY question
    ADD CONSTRAINT pkey PRIMARY KEY (id);


--
-- Name: reponse pkey_rep; Type: CONSTRAINT; Schema: public; Owner: qvgdm
--

ALTER TABLE ONLY reponse
    ADD CONSTRAINT pkey_rep PRIMARY KEY (id_rep);


--
-- Name: reponse fk_reponse_question; Type: FK CONSTRAINT; Schema: public; Owner: qvgdm
--

ALTER TABLE ONLY reponse
    ADD CONSTRAINT fk_reponse_question FOREIGN KEY (question) REFERENCES question(id);


--
-- PostgreSQL database dump complete
--

