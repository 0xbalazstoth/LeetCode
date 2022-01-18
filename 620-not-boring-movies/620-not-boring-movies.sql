SELECT id, movie, description, rating FROM cinema
WHERE(id % 2 != 0) && (description != "boring")
ORDER BY rating DESC;