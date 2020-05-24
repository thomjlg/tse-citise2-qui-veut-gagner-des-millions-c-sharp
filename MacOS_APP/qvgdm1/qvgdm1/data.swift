//
//  reponse.swift
//  qvgdm1
//
//  Created by Thomas JAULGEY on 23/05/2020.
//  Copyright © 2020 Thomas JAULGEY. All rights reserved.
//

import Foundation

struct reponse : Codable {
    var id_rep: Int
    var nom_rep: String
    var nom: String
    var question: Int
}

struct question : Codable {
    var id: Int
    var nom: String
}

let Question = Bundle.main.decode(question.self, from: "question.json")
let Reponse = Bundle.main.decode(reponse.self, from: "reponse.json")
