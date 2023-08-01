import pandas as pd
import numpy as np
import seaborn as sns
%matplotlib inline
import matplotlib.pyplot as plt
import math

from sklearn import model_selection
from sklearn.metrics import classification_report
from sklearn.metrics import accuracy_score
from sklearn.model_selection import train_test_split
from sklearn import metrics
from sklearn.neighbors import KNeighborsClassifier

bunga = pd.read_csv("IRIS.csv")
bunga.head()

bunga.plot(kind = 'box', subplots = True, layout = (2,2), sharex = False)
plt.show()

pd.plotting.scatter_matrix(bunga)
plt.show()

x = bunga.iloc[:, : -4].values
y = bunga.iloc[:, 4].values

X_train, X_test, y_train, y_test = model_selection.train_test_split(x, y, test_size = 0.2)

knn = KNeighborsClassifier (n_neighbors = 5)

knn.fit(X_train, y_train)
y_pred = knn.predict(X_test)

print("Accuracy 5 = ", metrics.accuracy_score(y_test, y_pred))

knn = KNeighborsClassifier (n_neighbors = 3)

knn.fit(X_train, y_train)
y_pred = knn.predict(X_test)

print("Accuracy 3 = ", metrics.accuracy_score(y_test, y_pred))
