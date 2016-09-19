;;****************
;;* DEFFUNCTIONS *
;;****************

(deffunction ask-question (?question $?allowed-values)
   (printout t ?question)
   (bind ?answer (read))
   (if (lexemep ?answer) 
       then (bind ?answer (lowcase ?answer)))
   (while (not (member ?answer ?allowed-values)) do
      (printout t ?question)
      (bind ?answer (read))
      (if (lexemep ?answer) 
          then (bind ?answer (lowcase ?answer))))
   ?answer)

(deffunction ask-about-price()
	(bind ?answer (ask-question "Выберите ценовой диапазон. 1: до 1 млн.; 2: от 1 до 3 млн.; 3: больше 3 млн.: " 1 2 3))
	?answer
)

(deffunction ask-about-seats(?allowed-values-str $?allowed-values)
	(bind ?question (str-cat "Выберите предпочитаемое количество мест. " ?allowed-values-str ": "))
	(bind ?answer (ask-question ?question ?allowed-values))
	?answer
)

(deffunction ask-about-speed()
	(bind ?answer (ask-question "Любите ли вы быструю езду? 1:да; 2:нет: " 1 2))
)

(deffunction ask-about-landskape(?allowed-values-str $?allowed-values)
	(bind ?question (str-cat "Выберите местность, по которой планируете перемещаться на своём автомобиле. " ?allowed-values-str ": "))
	(bind ?answer (ask-question ?question $?allowed-values))
	?answer
)

(deffunction ask-about-landskape-priority(?allowed-values-str $?allowed-values)
	(bind ?question (str-cat "Выберите местность, которой будете отдавать приоритет " ?allowed-values-str ": "))
	(bind ?answer (ask-question ?question $?allowed-values))
	?answer
)

(deffunction ask-about-carcase(?allowed-values-str $?allowed-values)
	(bind ?question (str-cat "Выберите тип кузова " ?allowed-values-str ": "))
	(bind ?answer (ask-question ?question $?allowed-values))
	?answer
)

;;;***************
;;;* QUERY RULES *
;;;***************

(defrule determine-price ""
	(not (price ?))
	=>
	(assert (price (ask-about-price)))
)

(defrule determine-seats1 ""
	(price 1)
	(not (seats ?))
	=>
	(assert (seats (ask-about-seats "2 или 5" 2 5)))
)

(defrule determine-speed1 ""
	(price 1)
	(seats 2)
	(not (speed ?))
	=>
	(assert (speed (ask-about-speed)))
)

(defrule determine-seats2 ""
	(price 2)
	(not (seats ?))
	=>
	(assert (seats (ask-about-seats "5 или 8" 5 8)))
)

(defrule determine-speed2 ""
	(price 2)
	(seats 5)
	(not (speed ?))
	=>
	(assert (speed (ask-about-speed)))
)

(defrule determine-landskape1 ""
	(price 2)
	(seats 5)
	(speed 1)
	(not (landskape ?))
	=>
	(assert (landskape (ask-about-landskape "1: внедорожье; 2: город и внедорожье:" 1 2)))
)

(defrule determine-landskape-priority1 ""
	(price 2)
	(seats 5)
	(speed 1)
	(landskape 2)
	(not (landskape-priority ?))
	=>
	(assert (landskape-priority (ask-about-landskape-priority "1: город, 2: внедорожье" 1 2)))
)

(defrule determine-speed3 ""
	(price 2)
	(seats 8)
	(not (speed ?))
	=>
	(assert (speed (ask-about-speed)))
)

(defrule determine-landskape2 ""
	(price 2)
	(seats 8)
	(speed 1)
	(not (landskape ?))
	=>
	(assert (landskape (ask-about-landskape "1: город; 2: город и внедорожье:" 1 2)))
)

(defrule determine-seats3 ""
	(price 3)
	(not (seats ?))
	=>
	(assert (seats (ask-about-seats "2 или 5 или 8" 2 5 8)))
)

(defrule determine-carcase1 ""
	(price 3)
	(seats 2)
	(not (carcase ?))
	=>
	(assert (carcase (ask-about-carcase "1: кабриолет; 2: купе" 1 2)))
)

(defrule determine-speed4 ""
	(price 3)
	(seats 5)
	(not (speed ?))
	=>
	(assert (speed (ask-about-speed)))
)

(defrule determine-speed5 ""
	(price 3)
	(seats 8)
	(not (speed ?))
	=>
	(assert (speed (ask-about-speed)))
)

(defrule determine-landskape3 ""
	(price 3)
	(seats 8)
	(speed 2)
	(not (landskape ?))
	=>
	(assert (landskape (ask-about-landskape "1: город; 2: внедорожье:" 1 2)))
)

;;;****************
;;;* REPAIR RULES *
;;;****************

(defrule suzuki-x-90
	(price 1)
	(seats 2)
	(speed 1)
	=>
	(assert (car "Suzuki-X-90"))
)

(defrule smart
	(price 1)
	(seats 2)
	(speed 2)
	=>
	(assert (car "Smart"))
)

(defrule uaz-patriot ""
	(price 1)
	(seats 5)
	=>
	(assert (car "УАЗ Патриот"))
)

(defrule audi-a6 ""
	(price 2)
	(seats 5)
	(speed 2)
	=>
	(assert (car "Audi A6"))
)

(defrule jeep-wrangler-sahara ""
	(price 2)
	(seats 5)
	(speed 1)
	(landskape 1)
	=>
	(assert (car "Jeep Wrangler Sahara"))
)

(defrule jeep-grand-cherokee ""
	(price 2)
	(seats 5)
	(speed 1)
	(landskape 2)
	(landskape-priority 1)
	=>
	(assert (car "Jeep Grand Cherokee"))
)

(defrule land-rover ""
	(price 2)
	(seats 5)
	(speed 1)
	(landskape 2)
	(landskape-priority 2)
	=>
	(assert (car "Land Rover"))
)

(defrule toyota-sequoia ""
	(price 2)
	(seats 8)
	(speed 2)
	=>
	(assert (car "Toyota Sequoia"))
)

(defrule mercedes-viano""
	(price 2)
	(seats 8)
	(speed 1)
	(landskape 1)
	=>
	(assert (car "Mercedes Viano"))
)

(defrule chevrolet-traverse""
	(price 2)
	(seats 8)
	(speed 1)
	(landskape 2)
	=>
	(assert (car "Chevrolet Traverse"))
)

(defrule ferrari-california""
	(price 3)
	(seats 2)
	(carcase 1)
	=>
	(assert (car "Ferrari California"))
)

(defrule bugatti-veyron""
	(price 3)
	(seats 2)
	(carcase 2)
	=>
	(assert (car "Bugatti Veyron"))
)

(defrule chevrolet-camaro""
	(price 3)
	(seats 5)
	(speed 1)
	=>
	(assert (car "Chevrolet Camaro"))
)

(defrule toyota-tundra""
	(price 3)
	(seats 5)
	(speed 2)
	=>
	(assert (car "Toyota Tundra"))
)

(defrule infinity-qx80""
	(price 3)
	(seats 8)
	(speed 1)
	=>
	(assert (car "Infinity QX80"))
)

(defrule cadillac-escalade""
	(price 3)
	(seats 8)
	(speed 2)
	(landskape 1)
	=>
	(assert (car "Cadillac Escalade"))
)

(defrule honda-pilot""
	(price 3)
	(seats 8)
	(speed 2)
	(landskape 2)
	=>
	(assert (car "Honda Pilot"))
)

;;;********************************
;;;* CONCLUSION RULE *
;;;********************************

(defrule print-car ""
  (declare (salience 10))
  (car ?item)
  =>
  (printout t crlf crlf)
  (printout t "Вам подходит автомобиль:")
  (printout t crlf crlf)
  (printout t ?item crlf crlf)
  )
